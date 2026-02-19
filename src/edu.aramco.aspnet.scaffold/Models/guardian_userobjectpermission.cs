using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class guardian_userobjectpermission
{
    public int id { get; set; }

    public string object_pk { get; set; } = null!;

    public int content_type_id { get; set; }

    public int permission_id { get; set; }

    public int user_id { get; set; }

    public virtual django_content_type content_type { get; set; } = null!;

    public virtual auth_permission permission { get; set; } = null!;

    public virtual auth_user user { get; set; } = null!;
}
