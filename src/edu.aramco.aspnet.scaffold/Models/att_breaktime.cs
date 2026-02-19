using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_breaktime
{
    public int id { get; set; }

    public string alias { get; set; } = null!;

    public DateTime period_start { get; set; }

    public int duration { get; set; }

    public int end_margin { get; set; }

    public short func_key { get; set; }

    public short available_interval_type { get; set; }

    public int available_interval { get; set; }

    public short multiple_punch { get; set; }

    public short calc_type { get; set; }

    public int? minimum_duration { get; set; }

    public short early_in { get; set; }

    public short late_in { get; set; }

    public bool profit_rule { get; set; }

    public int min_early_in { get; set; }

    public bool loss_rule { get; set; }

    public int min_late_in { get; set; }

    public int? loss_code_id { get; set; }

    public int? profit_code_id { get; set; }

    public short with_salary { get; set; }

    public virtual ICollection<att_timeinterval_break_time> att_timeinterval_break_times { get; set; } = new List<att_timeinterval_break_time>();

    public virtual att_paycode? loss_code { get; set; }

    public virtual att_paycode? profit_code { get; set; }
}
