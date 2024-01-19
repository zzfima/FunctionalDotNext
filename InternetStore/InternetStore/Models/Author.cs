using System;
using System.Collections.Generic;

namespace InternetStore.Models;

public partial class Author
{
    public int Id { get; set; }

    public string GivenName { get; set; } = null!;

    public string FamilyName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
