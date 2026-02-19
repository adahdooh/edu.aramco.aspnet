using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_errorcommandlog
{
    public int id { get; set; }

    public string? error_code { get; set; }

    public string? error_msg { get; set; }

    public string? data_origin { get; set; }

    public string? cmd { get; set; }

    public string? additional { get; set; }

    public DateTime upload_time { get; set; }

    public int terminal_id { get; set; }

    public virtual iclock_terminal terminal { get; set; } = null!;
}
