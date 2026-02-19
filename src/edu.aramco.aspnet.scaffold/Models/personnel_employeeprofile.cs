using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employeeprofile
{
    public int id { get; set; }

    public string column_order { get; set; } = null!;

    public string disabled_fields { get; set; } = null!;

    public string preferences { get; set; } = null!;

    public DateTime? pwd_update_time { get; set; }

    public int emp_id { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;
}
