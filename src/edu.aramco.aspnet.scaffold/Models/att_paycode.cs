using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_paycode
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string code { get; set; } = null!;

    public string name { get; set; } = null!;

    public short code_type { get; set; }

    public short? tag { get; set; }

    public short? fixed_code { get; set; }

    public bool is_work { get; set; }

    public decimal fixed_hours { get; set; }

    public bool is_paid { get; set; }

    public bool is_benefit { get; set; }

    public short round_off { get; set; }

    public decimal min_val { get; set; }

    public short display_format { get; set; }

    public string? symbol { get; set; }

    public short display_order { get; set; }

    public string? desc { get; set; }

    public bool is_display { get; set; }

    public bool is_default { get; set; }

    public string? color_setting { get; set; }

    public virtual ICollection<att_attpolicy> att_attpolicies { get; set; } = new List<att_attpolicy>();

    public virtual ICollection<att_breaktime> att_breaktimeloss_codes { get; set; } = new List<att_breaktime>();

    public virtual ICollection<att_breaktime> att_breaktimeprofit_codes { get; set; } = new List<att_breaktime>();

    public virtual ICollection<att_departmentpolicy> att_departmentpolicies { get; set; } = new List<att_departmentpolicy>();

    public virtual ICollection<att_grouppolicy> att_grouppolicies { get; set; } = new List<att_grouppolicy>();

    public virtual ICollection<att_leavegroupdetail> att_leavegroupdetails { get; set; } = new List<att_leavegroupdetail>();

    public virtual ICollection<att_leave> att_leaves { get; set; } = new List<att_leave>();

    public virtual ICollection<att_leaveyearbalance> att_leaveyearbalances { get; set; } = new List<att_leaveyearbalance>();

    public virtual ICollection<att_overtimepolicy> att_overtimepolicyovernight_pay_codes { get; set; } = new List<att_overtimepolicy>();

    public virtual ICollection<att_overtimepolicy> att_overtimepolicypay_codes { get; set; } = new List<att_overtimepolicy>();

    public virtual ICollection<att_overtime> att_overtimes { get; set; } = new List<att_overtime>();

    public virtual ICollection<att_payloadparing> att_payloadparings { get; set; } = new List<att_payloadparing>();

    public virtual ICollection<att_payloadpaycode> att_payloadpaycodes { get; set; } = new List<att_payloadpaycode>();

    public virtual ICollection<att_timeinterval> att_timeintervals { get; set; } = new List<att_timeinterval>();

    public virtual ICollection<att_training> att_trainings { get; set; } = new List<att_training>();

    public virtual ICollection<payroll_exceptionformula> payroll_exceptionformulas { get; set; } = new List<payroll_exceptionformula>();

    public virtual ICollection<payroll_leaveformula> payroll_leaveformulas { get; set; } = new List<payroll_leaveformula>();

    public virtual ICollection<payroll_overtimeformula> payroll_overtimeformulas { get; set; } = new List<payroll_overtimeformula>();

    public virtual ICollection<payroll_payrollpayloadpaycode> payroll_payrollpayloadpaycodes { get; set; } = new List<payroll_payrollpayloadpaycode>();
}
