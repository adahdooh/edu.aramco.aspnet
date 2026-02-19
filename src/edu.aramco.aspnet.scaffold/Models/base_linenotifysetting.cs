using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_linenotifysetting
{
    public int id { get; set; }

    public int? include_sub_department { get; set; }

    public string? line_notify_token { get; set; }

    public int? message_type { get; set; }

    public string? message_head { get; set; }

    public string? message_tail { get; set; }

    public DateTime? push_time { get; set; }

    public int? is_valid { get; set; }

    public string? remark { get; set; }

    public int? line_notify_dept_id { get; set; }

    public virtual personnel_department? line_notify_dept { get; set; }
}
