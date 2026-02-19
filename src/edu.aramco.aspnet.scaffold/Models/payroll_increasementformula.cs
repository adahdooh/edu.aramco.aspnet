using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_increasementformula
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string formula { get; set; } = null!;

    public string? remark { get; set; }

    public virtual ICollection<payroll_salarystructure_increasementformula> payroll_salarystructure_increasementformulas { get; set; } = new List<payroll_salarystructure_increasementformula>();
}
