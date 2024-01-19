using InternetStore.Models;

internal class ProgramEF
{
    private static void Main(string[] args)
    {
        using (var db = new InternetBooksStoreContext())
        {
            var whereIsAlex1 = (from b in db.Books
                                where b.Title == "Alex"
                                || b.Publisher.Title == "Alex"
                                || b.Author.FamilyName == "Alex"
                                || b.Author.GivenName == "Alex"
                                select b)
                            .ToList();
        }

        Console.ReadLine();
    }
}