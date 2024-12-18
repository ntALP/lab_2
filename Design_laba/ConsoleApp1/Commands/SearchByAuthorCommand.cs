using System;
using System.Collections.Generic;
using System.Linq;

public class SearchByAuthorCommand : ICommand
{
    private readonly BookCatalog _catalog;

    public SearchByAuthorCommand(BookCatalog catalog)
    {
        _catalog = catalog;
    }

    public void Execute()
    {
        Console.Write("Введите имя автора: ");
        string author = Console.ReadLine();
        var results = _catalog.SearchByAuthor(author);
        DisplayResults(results);
    }

    private void DisplayResults(List<Book> books)
    {
        if (books.Any())
        {
            Console.WriteLine("Найдены следующие книги:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine("Книги не найдены.");
        }
    }
} 