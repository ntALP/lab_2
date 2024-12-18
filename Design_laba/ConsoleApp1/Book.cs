using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public List<string> Genres { get; set; }
    public int PublicationYear { get; set; }
    public string Description { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, List<string> genres, int publicationYear, string description, string isbn)
    {
        Title = title;
        Author = author;
        Genres = genres;
        PublicationYear = publicationYear;
        Description = description;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return $"{Title}, {Author}, {string.Join(", ", Genres)}, {PublicationYear}, ISBN: {ISBN}";
    }
} 