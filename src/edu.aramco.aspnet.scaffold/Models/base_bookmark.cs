using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_bookmark
{
    public int id { get; set; }

    public string title { get; set; } = null!;

    public string filters { get; set; } = null!;

    public bool is_share { get; set; }

    public DateTime time_saved { get; set; }

    public int content_type_id { get; set; }

    public int? user_id { get; set; }

    public virtual django_content_type content_type { get; set; } = null!;

    public virtual auth_user? user { get; set; }
}
