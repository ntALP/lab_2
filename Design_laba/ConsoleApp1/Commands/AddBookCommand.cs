using System;
using System.Collections.Generic;
using System.Linq;

public class AddBookCommand : ICommand
{
    private readonly BookCatalog _catalog;

    public AddBookCommand(BookCatalog catalog)
    {
        _catalog = catalog;
    }

    public void Execute()
    {
        Console.Write("Введите название книги: ");
        string title = Console.ReadLine();

        Console.Write("Введите имя автора: ");
        string author = Console.ReadLine();

        Console.Write("Введите жанры (через запятую): ");
        List<string> genres = Console.ReadLine().Split(',').Select(g => g.Trim()).ToList();

        Console.Write("Введите дату публикации (ГГГГ): ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Введите аннотацию: ");
        string description = Console.ReadLine();

        Console.Write("Введите ISBN: ");
        string isbn = Console.ReadLine();

        var book = new Book(title, author, genres, year, description, isbn);
        _catalog.AddBook(book);
        Console.WriteLine("Книга добавлена в каталог!");
    }
} 