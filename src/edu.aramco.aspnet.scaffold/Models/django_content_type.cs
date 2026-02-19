using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_content_type
{
    public int id { get; set; }

    public string app_label { get; set; } = null!;

    public string model { get; set; } = null!;

    public virtual ICollection<auth_permission> auth_permissions { get; set; } = new List<auth_permission>();

    public virtual ICollection<base_adminlog> base_adminlogs { get; set; } = new List<base_adminlog>();

    public virtual ICollection<base_bookmark> base_bookmarks { get; set; } = new List<base_bookmark>();

    public virtual ICollection<django_admin_log> django_admin_logs { get; set; } = new List<django_admin_log>();

    public virtual ICollection<guardian_groupobjectpermission> guardian_groupobjectpermissions { get; set; } = new List<guardian_groupobjectpermission>();

    public virtual ICollection<guardian_userobjectpermission> guardian_userobjectpermissions { get; set; } = new List<guardian_userobjectpermission>();

    public virtual ICollection<workflow_workflowengine> workflow_workflowengines { get; set; } = new List<workflow_workflowengine>();
}
