using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_adminlog
{
    public int id { get; set; }

    public string action { get; set; } = null!;

    public string? targets { get; set; }

    public string? targets_repr { get; set; }

    public short action_status { get; set; }

    public string? description { get; set; }

    public string? ip_address { get; set; }

    public bool can_routable { get; set; }

    public DateTime op_time { get; set; }

    public int? content_type_id { get; set; }

    public int user_id { get; set; }

    public virtual django_content_type? content_type { get; set; }

    public virtual auth_user user { get; set; } = null!;
}
