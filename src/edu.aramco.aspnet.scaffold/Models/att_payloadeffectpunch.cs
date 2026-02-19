using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadeffectpunch
{
    public string id { get; set; } = null!;

    public DateTime att_date { get; set; }

    public DateTime punch_datetime { get; set; }

    public DateTime punch_date { get; set; }

    public DateTime punch_time { get; set; }

    public short week { get; set; }

    public short weekday { get; set; }

    public string work_code { get; set; } = null!;

    public string punch_state { get; set; } = null!;

    public string adjust_state { get; set; } = null!;

    public int emp_id { get; set; }

    public string? time_card_id { get; set; }

    public int trans_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual iclock_transaction trans { get; set; } = null!;
}
