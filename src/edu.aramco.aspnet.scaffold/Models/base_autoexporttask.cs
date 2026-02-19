using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_autoexporttask
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string task_code { get; set; } = null!;

    public string task_name { get; set; } = null!;

    public string? _params { get; set; }

    public bool enable { get; set; }

    public DateTime? process_time { get; set; }
}
