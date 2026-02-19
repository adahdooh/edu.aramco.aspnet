using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_salarystructure_exceptionformula
{
    public int id { get; set; }

    public int salarystructure_id { get; set; }

    public int exceptionformula_id { get; set; }

    public virtual payroll_exceptionformula exceptionformula { get; set; } = null!;

    public virtual payroll_salarystructure salarystructure { get; set; } = null!;
}
