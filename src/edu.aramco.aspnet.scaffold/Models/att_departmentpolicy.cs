using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_departmentpolicy
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public short use_ot { get; set; }

    public short weekend1 { get; set; }

    public short weekend2 { get; set; }

    public short start_of_week { get; set; }

    public decimal max_hrs { get; set; }

    public DateTime day_change { get; set; }

    public short paring_rule { get; set; }

    public short overtime_policy { get; set; }

    public short punch_period { get; set; }

    public bool daily_ot { get; set; }

    public string? daily_ot_rule { get; set; }

    public bool weekly_ot { get; set; }

    public string? weekly_ot_rule { get; set; }

    public bool weekend_ot { get; set; }

    public string? weekend_ot_rule { get; set; }

    public bool holiday_ot { get; set; }

    public string? holiday_ot_rule { get; set; }

    public int late_in2absence { get; set; }

    public int early_out2absence { get; set; }

    public short miss_in { get; set; }

    public int late_in_hrs { get; set; }

    public short miss_out { get; set; }

    public int early_out_hrs { get; set; }

    public bool require_capture { get; set; }

    public bool require_work_code { get; set; }

    public bool require_punch_state { get; set; }

    public short max_late_in { get; set; }

    public short max_early_out { get; set; }

    public short max_absent { get; set; }

    public short dept_frequency { get; set; }

    public short dept_send_day { get; set; }

    public DateTime email_send_time { get; set; }

    public short sending_day { get; set; }

    public string? weekend1_color_setting { get; set; }

    public string? weekend2_color_setting { get; set; }

    public int department_id { get; set; }

    public int? ot_pay_code_id { get; set; }

    public bool enable_compensatory { get; set; }

    public virtual personnel_department department { get; set; } = null!;

    public virtual att_paycode? ot_pay_code { get; set; }
}
