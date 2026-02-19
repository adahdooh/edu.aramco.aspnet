using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_leaveyearbalance
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int? leave_type { get; set; }

    public int? year { get; set; }

    public short? entitlement_days { get; set; }

    public double? leave_day { get; set; }

    public short? pre_balance { get; set; }

    public int employee_id { get; set; }

    public int? pay_code_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual att_paycode? pay_code { get; set; }
}
