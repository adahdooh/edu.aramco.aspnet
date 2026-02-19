using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadparing
{
    public string id { get; set; } = null!;

    public long stamp { get; set; }

    public DateTime att_date { get; set; }

    public short week { get; set; }

    public short weekday { get; set; }

    public short data_type { get; set; }

    public DateTime? clock_in { get; set; }

    public DateTime? in_date { get; set; }

    public DateTime? in_time { get; set; }

    public DateTime? clock_out { get; set; }

    public DateTime? out_date { get; set; }

    public DateTime? out_time { get; set; }

    public int duration { get; set; }

    public int worked_duration { get; set; }

    public int data_index { get; set; }

    public decimal workday { get; set; }

    public int emp_id { get; set; }

    public int? in_trans_id { get; set; }

    public int? out_trans_id { get; set; }

    public int? pay_code_id { get; set; }

    public string? time_card_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual iclock_transaction? in_trans { get; set; }

    public virtual iclock_transaction? out_trans { get; set; }

    public virtual att_paycode? pay_code { get; set; }
}
