using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_user_group
{
    public int id { get; set; }

    public int myuser_id { get; set; }

    public int group_id { get; set; }

    public virtual auth_group group { get; set; } = null!;

    public virtual auth_user myuser { get; set; } = null!;
}
