using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminalparameter
{
    public int id { get; set; }

    public string? param_type { get; set; }

    public string param_name { get; set; } = null!;

    public string param_value { get; set; } = null!;

    public int terminal_id { get; set; }

    public virtual iclock_terminal terminal { get; set; } = null!;
}
