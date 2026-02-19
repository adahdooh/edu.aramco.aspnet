using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attschedule
{
    public int id { get; set; }

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public int employee_id { get; set; }

    public int shift_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual att_attshift shift { get; set; } = null!;
}
