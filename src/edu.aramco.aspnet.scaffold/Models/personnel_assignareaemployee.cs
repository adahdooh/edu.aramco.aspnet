using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_assignareaemployee
{
    public int id { get; set; }

    public DateTime assigned_time { get; set; }

    public int area_id { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_area area { get; set; } = null!;

    public virtual personnel_employee employee { get; set; } = null!;
}
