using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_permission
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public int content_type_id { get; set; }

    public string codename { get; set; } = null!;

    public virtual ICollection<auth_group_permission> auth_group_permissions { get; set; } = new List<auth_group_permission>();

    public virtual ICollection<auth_user_user_permission> auth_user_user_permissions { get; set; } = new List<auth_user_user_permission>();

    public virtual django_content_type content_type { get; set; } = null!;

    public virtual ICollection<guardian_groupobjectpermission> guardian_groupobjectpermissions { get; set; } = new List<guardian_groupobjectpermission>();

    public virtual ICollection<guardian_userobjectpermission> guardian_userobjectpermissions { get; set; } = new List<guardian_userobjectpermission>();
}
