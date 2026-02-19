using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employeecustomattribute
{
    public int id { get; set; }

    public string attr_name { get; set; } = null!;

    public short attr_type { get; set; }

    public string? attr_value { get; set; }

    public bool is_unique { get; set; }

    public bool enable { get; set; }
}
