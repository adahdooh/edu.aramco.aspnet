using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_salarystructure_deductionformula
{
    public int id { get; set; }

    public int salarystructure_id { get; set; }

    public int deductionformula_id { get; set; }

    public virtual payroll_deductionformula deductionformula { get; set; } = null!;

    public virtual payroll_salarystructure salarystructure { get; set; } = null!;
}
