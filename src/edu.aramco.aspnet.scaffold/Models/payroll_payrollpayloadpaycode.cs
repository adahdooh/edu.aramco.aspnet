using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_payrollpayloadpaycode
{
    public int id { get; set; }

    public double? amount { get; set; }

    public string? formula { get; set; }

    public string? formula_name { get; set; }

    public int pay_code_id { get; set; }

    public int payload_id { get; set; }

    public virtual att_paycode pay_code { get; set; } = null!;

    public virtual payroll_payrollpayload payload { get; set; } = null!;
}
