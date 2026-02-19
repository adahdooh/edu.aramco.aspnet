using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_sysparam
{
    public int id { get; set; }

    public string para_name { get; set; } = null!;

    public string? para_type { get; set; }

    public string? para_value { get; set; }
}
