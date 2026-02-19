using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_leavegroupdetail
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int leave_type { get; set; }

    public int allow_leave_day { get; set; }

    public double min_leave_day { get; set; }

    public short deduct_holiday_day { get; set; }

    public int? leave_entitlement { get; set; }

    public int leave_interval { get; set; }

    public int? leave_distribution_time { get; set; }

    public string start_day { get; set; } = null!;

    public short set_hire_day { get; set; }

    public short allow_exceed_limit { get; set; }

    public short allow_balance { get; set; }

    public int? max_balance { get; set; }

    public string? entitlement_detail { get; set; }

    public int leave_group_id { get; set; }

    public int? pay_code_id { get; set; }

    public virtual att_leavegroup leave_group { get; set; } = null!;

    public virtual att_paycode? pay_code { get; set; }
}
