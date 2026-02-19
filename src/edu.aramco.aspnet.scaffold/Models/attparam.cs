using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class attparam
{
    public int id { get; set; }

    public string paraname { get; set; } = null!;

    public string? paratype { get; set; }

    public string? paravalue { get; set; }
}
