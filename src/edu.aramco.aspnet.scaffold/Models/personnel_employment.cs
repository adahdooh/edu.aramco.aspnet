using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employment
{
    public int id { get; set; }

    public short employment_type { get; set; }

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public DateTime? active_time { get; set; }

    public DateTime? inactive_time { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;
}
