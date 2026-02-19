using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_resign
{
    public int id { get; set; }

    public DateTime resign_date { get; set; }

    public int? resign_type { get; set; }

    public bool disableatt { get; set; }

    public string? reason { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;
}
