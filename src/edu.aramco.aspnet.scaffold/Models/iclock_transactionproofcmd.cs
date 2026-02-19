using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_transactionproofcmd
{
    public int id { get; set; }

    public DateTime action_time { get; set; }

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public int? terminal_count { get; set; }

    public int? server_count { get; set; }

    public short? flag { get; set; }

    public int? reserved_init { get; set; }

    public double? reserved_float { get; set; }

    public string? reserved_char { get; set; }

    public int terminal_id { get; set; }

    public virtual iclock_terminal terminal { get; set; } = null!;
}
