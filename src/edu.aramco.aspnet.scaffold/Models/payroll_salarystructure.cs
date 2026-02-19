using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_salarystructure
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public double salary_amount { get; set; }

    public DateTime effective_date { get; set; }

    public string? salary_remark { get; set; }

    public int? employee_id { get; set; }

    public virtual personnel_employee? employee { get; set; }

    public virtual ICollection<payroll_salarystructure_deductionformula> payroll_salarystructure_deductionformulas { get; set; } = new List<payroll_salarystructure_deductionformula>();

    public virtual ICollection<payroll_salarystructure_exceptionformula> payroll_salarystructure_exceptionformulas { get; set; } = new List<payroll_salarystructure_exceptionformula>();

    public virtual ICollection<payroll_salarystructure_increasementformula> payroll_salarystructure_increasementformulas { get; set; } = new List<payroll_salarystructure_increasementformula>();

    public virtual ICollection<payroll_salarystructure_leaveformula> payroll_salarystructure_leaveformulas { get; set; } = new List<payroll_salarystructure_leaveformula>();

    public virtual ICollection<payroll_salarystructure_overtimeformula> payroll_salarystructure_overtimeformulas { get; set; } = new List<payroll_salarystructure_overtimeformula>();
}
