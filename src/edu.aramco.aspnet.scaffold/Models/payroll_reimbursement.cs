using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_reimbursement
{
    public int id { get; set; }

    public double rmb_amount { get; set; }

    public DateTime rmb_time { get; set; }

    public string? rmb_file { get; set; }

    public string? rmb_remark { get; set; }

    public int? employee_id { get; set; }

    public virtual personnel_employee? employee { get; set; }
}
