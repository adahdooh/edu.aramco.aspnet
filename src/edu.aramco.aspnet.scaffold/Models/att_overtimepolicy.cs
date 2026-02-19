using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_overtimepolicy
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public short mode { get; set; }

    public decimal hrs_from { get; set; }

    public decimal hrs_to { get; set; }

    public string master { get; set; } = null!;

    public int? overnight_pay_code_id { get; set; }

    public int? pay_code_id { get; set; }

    public virtual att_paycode? overnight_pay_code { get; set; }

    public virtual att_paycode? pay_code { get; set; }
}
