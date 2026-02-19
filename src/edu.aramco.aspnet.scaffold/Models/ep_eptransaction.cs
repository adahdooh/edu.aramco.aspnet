using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class ep_eptransaction
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string emp_code { get; set; } = null!;

    public string area { get; set; } = null!;

    public DateTime? check_datetime { get; set; }

    public DateTime check_date { get; set; }

    public DateTime check_time { get; set; }

    public decimal temperature { get; set; }

    public int is_mask { get; set; }

    public DateTime upload_time { get; set; }

    public short source { get; set; }

    public string? terminal_sn { get; set; }

    public int? emp_id { get; set; }

    public int? terminal_id { get; set; }

    public virtual personnel_employee? emp { get; set; }

    public virtual iclock_terminal? terminal { get; set; }
}
