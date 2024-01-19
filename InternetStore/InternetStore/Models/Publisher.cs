﻿using System;
using System.Collections.Generic;

namespace InternetStore.Models;

public partial class Publisher
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
