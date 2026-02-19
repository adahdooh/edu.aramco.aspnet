using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminallog
{
    public int id { get; set; }

    public short? terminal_tz { get; set; }

    public string? admin { get; set; }

    public short? action_name { get; set; }

    public DateTime? action_time { get; set; }

    public string? _object { get; set; }

    public int? param1 { get; set; }

    public int? param2 { get; set; }

    public int? param3 { get; set; }

    public DateTime? upload_time { get; set; }

    public int terminal_id { get; set; }

    public virtual iclock_terminal terminal { get; set; } = null!;
}
