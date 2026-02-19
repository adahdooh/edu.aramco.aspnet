using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_user_auth_dept
{
    public int id { get; set; }

    public int myuser_id { get; set; }

    public int department_id { get; set; }

    public virtual personnel_department department { get; set; } = null!;

    public virtual auth_user myuser { get; set; } = null!;
}
