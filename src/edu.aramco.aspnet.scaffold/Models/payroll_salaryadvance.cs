using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_salaryadvance
{
    public int id { get; set; }

    public double advance_amount { get; set; }

    public DateTime advance_time { get; set; }

    public string? advance_remark { get; set; }

    public int? employee_id { get; set; }

    public virtual personnel_employee? employee { get; set; }
}
