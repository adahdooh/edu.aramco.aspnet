using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_salarystructure_overtimeformula
{
    public int id { get; set; }

    public int salarystructure_id { get; set; }

    public int overtimeformula_id { get; set; }

    public virtual payroll_overtimeformula overtimeformula { get; set; } = null!;

    public virtual payroll_salarystructure salarystructure { get; set; } = null!;
}
