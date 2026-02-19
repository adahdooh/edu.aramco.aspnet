using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_salarystructure_increasementformula
{
    public int id { get; set; }

    public int salarystructure_id { get; set; }

    public int increasementformula_id { get; set; }

    public virtual payroll_increasementformula increasementformula { get; set; } = null!;

    public virtual payroll_salarystructure salarystructure { get; set; } = null!;
}
