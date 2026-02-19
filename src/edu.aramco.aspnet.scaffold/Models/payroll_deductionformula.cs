using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_deductionformula
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string formula { get; set; } = null!;

    public string? remark { get; set; }

    public virtual ICollection<payroll_salarystructure_deductionformula> payroll_salarystructure_deductionformulas { get; set; } = new List<payroll_salarystructure_deductionformula>();
}
