using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_emploan
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public double loan_amount { get; set; }

    public DateTime loan_time { get; set; }

    public short refund_cycle { get; set; }

    public double per_cycle_refund { get; set; }

    public DateTime? loan_clean_time { get; set; }

    public string? remark { get; set; }

    public int? employee_id { get; set; }

    public virtual personnel_employee? employee { get; set; }
}
