using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_emppayrollprofile
{
    public int id { get; set; }

    public short? payment_mode { get; set; }

    public short? payment_type { get; set; }

    public string? bank_name { get; set; }

    public string? bank_account { get; set; }

    public string? personnel_id { get; set; }

    public string? agent_id { get; set; }

    public string? agent_account { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;
}
