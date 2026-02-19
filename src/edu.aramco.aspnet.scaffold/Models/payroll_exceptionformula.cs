using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_exceptionformula
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string formula { get; set; } = null!;

    public string? remark { get; set; }

    public int pay_code_id { get; set; }

    public virtual att_paycode pay_code { get; set; } = null!;

    public virtual ICollection<payroll_salarystructure_exceptionformula> payroll_salarystructure_exceptionformulas { get; set; } = new List<payroll_salarystructure_exceptionformula>();
}
