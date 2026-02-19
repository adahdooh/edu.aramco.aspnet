using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_timeinterval
{
    public int id { get; set; }

    public string alias { get; set; } = null!;

    public short use_mode { get; set; }

    public DateTime in_time { get; set; }

    public int in_ahead_margin { get; set; }

    public int in_above_margin { get; set; }

    public int out_ahead_margin { get; set; }

    public int out_above_margin { get; set; }

    public int duration { get; set; }

    public short in_required { get; set; }

    public short out_required { get; set; }

    public int allow_late { get; set; }

    public int allow_leave_early { get; set; }

    public double work_day { get; set; }

    public short early_in { get; set; }

    public int min_early_in { get; set; }

    public bool count_early_in_interval { get; set; }

    public short late_out { get; set; }

    public int min_late_out { get; set; }

    public bool count_late_out_interval { get; set; }

    public short overtime_lv { get; set; }

    public short overtime_lv1 { get; set; }

    public short overtime_lv2 { get; set; }

    public short overtime_lv3 { get; set; }

    public short multiple_punch { get; set; }

    public short available_interval_type { get; set; }

    public int available_interval { get; set; }

    public int work_time_duration { get; set; }

    public short func_key { get; set; }

    public short work_type { get; set; }

    public DateTime day_change { get; set; }

    public bool enable_early_in { get; set; }

    public bool enable_late_out { get; set; }

    public bool enable_overtime { get; set; }

    public string? ot_rule { get; set; }

    public string? color_setting { get; set; }

    public bool enable_max_ot_limit { get; set; }

    public int max_ot_limit { get; set; }

    public short overtime_policy { get; set; }

    public int? ot_pay_code_id { get; set; }

    public virtual ICollection<att_changeschedule> att_changeschedules { get; set; } = new List<att_changeschedule>();

    public virtual ICollection<att_payloadbase> att_payloadbases { get; set; } = new List<att_payloadbase>();

    public virtual ICollection<att_payloadtimecard> att_payloadtimecards { get; set; } = new List<att_payloadtimecard>();

    public virtual ICollection<att_shiftdetail> att_shiftdetails { get; set; } = new List<att_shiftdetail>();

    public virtual ICollection<att_timeinterval_break_time> att_timeinterval_break_times { get; set; } = new List<att_timeinterval_break_time>();

    public virtual att_paycode? ot_pay_code { get; set; }
}
