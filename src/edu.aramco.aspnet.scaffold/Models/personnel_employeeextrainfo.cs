using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employeeextrainfo
{
    public int id { get; set; }

    public string value { get; set; } = null!;

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;
}
