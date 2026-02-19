using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_user_user_permission
{
    public int id { get; set; }

    public int myuser_id { get; set; }

    public int permission_id { get; set; }

    public virtual auth_user myuser { get; set; } = null!;

    public virtual auth_permission permission { get; set; } = null!;
}
