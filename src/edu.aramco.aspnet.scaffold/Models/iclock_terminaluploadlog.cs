using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminaluploadlog
{
    public int id { get; set; }

    public string _event { get; set; } = null!;

    public string content { get; set; } = null!;

    public int upload_count { get; set; }

    public int error_count { get; set; }

    public DateTime upload_time { get; set; }

    public int terminal_id { get; set; }

    public virtual iclock_terminal terminal { get; set; } = null!;
}
