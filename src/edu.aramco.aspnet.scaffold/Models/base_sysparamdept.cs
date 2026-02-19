using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_sysparamdept
{
    public int id { get; set; }

    public string rule_name { get; set; } = null!;

    public int dept_id { get; set; }

    public string? _operator { get; set; }

    public DateTime? op_time { get; set; }
}
