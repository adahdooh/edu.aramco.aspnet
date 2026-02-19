using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_extradeduction
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public double amount { get; set; }

    public DateTime issued_time { get; set; }

    public string? remark { get; set; }

    public int? employee_id { get; set; }

    public virtual personnel_employee? employee { get; set; }
}
