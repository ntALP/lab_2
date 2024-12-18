using System;

public class SearchByISBNCommand : ICommand
{
    private readonly BookCatalog _catalog;

    public SearchByISBNCommand(BookCatalog catalog)
    {
        _catalog = catalog;
    }

    public void Execute()
    {
        Console.Write("Введите ISBN: ");
        string isbn = Console.ReadLine();
        var book = _catalog.SearchByISBN(isbn);
        if (book != null)
            Console.WriteLine(book);
        else
            Console.WriteLine("Книга не найдена.");
    }
} 