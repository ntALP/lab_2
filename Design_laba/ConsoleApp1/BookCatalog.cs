using System;
using System.Collections.Generic;
using System.Linq;

public class BookCatalog
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> SearchByTitle(string titleFragment)
    {
        return books.Where(b => b.Title.Contains(titleFragment, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public Book SearchByISBN(string isbn)
    {
        return books.FirstOrDefault(b => b.ISBN == isbn);
    }

    public List<(Book book, int matchCount, List<string> matchedWords)> SearchByKeywords(List<string> keywords)
    {
        var results = new List<(Book book, int matchCount, List<string> matchedWords)>();

        foreach (var book in books)
        {
            var matchedWords = new List<string>();
            foreach (var keyword in keywords)
            {
                if (book.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    matchedWords.Add(keyword);
                }
            }

            if (matchedWords.Count > 0)
            {
                results.Add((book, matchedWords.Count, matchedWords));
            }
        }

        return results.OrderByDescending(r => r.matchCount).ToList();
    }
} 