using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employeecertification
{
    public int id { get; set; }

    public DateTime? expire_on { get; set; }

    public bool email_alert { get; set; }

    public int? before { get; set; }

    public string? certification_code { get; set; }

    public string? file_name { get; set; }

    public string? file { get; set; }

    public int certification_id { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_certification certification { get; set; } = null!;

    public virtual personnel_employee employee { get; set; } = null!;
}
