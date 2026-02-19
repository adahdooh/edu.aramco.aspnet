using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_attparamdept
{
    public int id { get; set; }

    public string rulename { get; set; } = null!;

    public int deptid { get; set; }

    public string? _operator { get; set; }

    public DateTime? optime { get; set; }
}
