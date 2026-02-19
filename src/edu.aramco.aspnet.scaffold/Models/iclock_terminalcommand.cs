using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminalcommand
{
    public int id { get; set; }

    public string content { get; set; } = null!;

    public DateTime commit_time { get; set; }

    public DateTime? transfer_time { get; set; }

    public DateTime? return_time { get; set; }

    public int? return_value { get; set; }

    public int? package { get; set; }

    public int terminal_id { get; set; }

    public virtual iclock_terminal terminal { get; set; } = null!;
}
