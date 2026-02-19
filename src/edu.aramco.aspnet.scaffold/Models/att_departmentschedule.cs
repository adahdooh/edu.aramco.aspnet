using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_departmentschedule
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public int department_id { get; set; }

    public int shift_id { get; set; }

    public virtual personnel_department department { get; set; } = null!;

    public virtual att_attshift shift { get; set; } = null!;
}
