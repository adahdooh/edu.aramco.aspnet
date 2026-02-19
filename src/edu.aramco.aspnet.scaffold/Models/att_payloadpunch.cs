using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadpunch
{
    public string uuid { get; set; } = null!;

    public DateTime? att_date { get; set; }

    public string? correct_state { get; set; }

    public int emp_id { get; set; }

    public int? orig_id { get; set; }

    public string? skd_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual iclock_transaction? orig { get; set; }
}
