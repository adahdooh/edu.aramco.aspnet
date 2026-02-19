using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_migration
{
    public int id { get; set; }

    public string app { get; set; } = null!;

    public string name { get; set; } = null!;

    public DateTime applied { get; set; }
}
