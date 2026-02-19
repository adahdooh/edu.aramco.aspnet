using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_user_auth_area
{
    public int id { get; set; }

    public int myuser_id { get; set; }

    public int area_id { get; set; }

    public virtual personnel_area area { get; set; } = null!;

    public virtual auth_user myuser { get; set; } = null!;
}
