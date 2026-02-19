using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class guardian_groupobjectpermission
{
    public int id { get; set; }

    public string object_pk { get; set; } = null!;

    public int content_type_id { get; set; }

    public int group_id { get; set; }

    public int permission_id { get; set; }

    public virtual django_content_type content_type { get; set; } = null!;

    public virtual auth_group group { get; set; } = null!;

    public virtual auth_permission permission { get; set; } = null!;
}
