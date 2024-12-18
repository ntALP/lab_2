using System;
using System.Collections.Generic;
using System.Linq;

public class SearchByKeywordsCommand : ICommand
{
    private readonly BookCatalog _catalog;

    public SearchByKeywordsCommand(BookCatalog catalog)
    {
        _catalog = catalog;
    }

    public void Execute()
    {
        Console.Write("Введите ключевые слова (через запятую): ");
        var keywords = Console.ReadLine().Split(',').Select(k => k.Trim()).ToList();
        var results = _catalog.SearchByKeywords(keywords);
        
        foreach (var (book, count, matchedWords) in results)
        {
            Console.WriteLine($"{book} (ключевые слова найдены в аннотации: {string.Join(", ", matchedWords)})");
        }
    }
} 