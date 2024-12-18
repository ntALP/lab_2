using System;
using System.Collections.Generic;
using System.Linq;

public class SearchByTitleCommand : ICommand
{
    private readonly BookCatalog _catalog;

    public SearchByTitleCommand(BookCatalog catalog)
    {
        _catalog = catalog;
    }

    public void Execute()
    {
        Console.Write("Введите название или его фрагмент: ");
        string titleFragment = Console.ReadLine();
        var results = _catalog.SearchByTitle(titleFragment);
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