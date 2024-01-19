class Publisher
{
    public string Title { get; set; }
}

class Author
{
    public string GivenName { get; set; }
    public string FamilyName { get; set; }
}

class Book
{
    public string Title { get; set; }
    public Publisher Publisher { get; set; }
    public Author[] Authors { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Author[] authors =
        [
            new Author() { GivenName = "Alex", FamilyName = "Martin" },
            new Author() { GivenName = "Mike", FamilyName = "Baker" },
            new Author() { GivenName = "John", FamilyName = "Abe" },
        ];

        Publisher[] publishers =
        [
            new Publisher() { Title = "Rock" },
            new Publisher() { Title = "Alex" },
            new Publisher() { Title = "River" },
        ];


        List<Book> books = new List<Book>();
        books.Add(new Book()
        {
            Title = "Nature",
            Authors = [authors[0]],
            Publisher = publishers[0]
        });

        books.Add(new Book()
        {
            Title = "Animals",
            Authors = [authors[0]],
            Publisher = publishers[1]
        });

        books.Add(new Book()
        {
            Title = "Birds",
            Authors = [authors[1]],
            Publisher = publishers[1]
        });

        var whereIsAlex1 = (from b in books
                            where b.Title == "Alex"
                            || b.Publisher.Title == "Alex"
                            || b.Authors.Any(a => a.FamilyName == "Alex" || a.GivenName == "Alex") select b)
                            .ToList();

        var whereIsAlex2 = books.Where(b => b.Title == "Alex"
        || b.Publisher.Title == "Alex"
        || b.Authors.Any(a => a.FamilyName == "Alex" || a.GivenName == "Alex"))
            .ToList();


    }
}