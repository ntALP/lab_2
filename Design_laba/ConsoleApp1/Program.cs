using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static BookCatalog catalog = new BookCatalog();
    private static Dictionary<string, ICommand> commands;

    static void Main(string[] args)
    {
        InitializeCommands();

        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            if (commands.ContainsKey(choice))
            {
                commands[choice].Execute();
            }
            else
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
            }
        }
    }

    static void InitializeCommands()
    {
        commands = new Dictionary<string, ICommand>
        {
            { "1", new AddBookCommand(catalog) },
            { "2", new SearchByTitleCommand(catalog) },
            { "3", new SearchByAuthorCommand(catalog) },
            { "4", new SearchByISBNCommand(catalog) },
            { "5", new SearchByKeywordsCommand(catalog) },
            { "6", new ExitCommand() }
        };
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nДобро пожаловать в каталог книг! Выберите действие:");
        Console.WriteLine("1. Добавить книгу в каталог");
        Console.WriteLine("2. Найти книгу по названию");
        Console.WriteLine("3. Найти книгу по имени автора");
        Console.WriteLine("4. Найти книгу по ISBN");
        Console.WriteLine("5. Найти книги по ключевым словам");
        Console.WriteLine("6. Выйти");
        Console.Write("Ваш выбор: ");
    }
}