using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_user_profile
{
    public int id { get; set; }

    public string login_name { get; set; } = null!;

    public string pin_tabs { get; set; } = null!;

    public string disabled_fields { get; set; } = null!;

    public string column_order { get; set; } = null!;

    public string preferences { get; set; } = null!;

    public DateTime? pwd_update_time { get; set; }

    public int user_id { get; set; }

    public virtual auth_user user { get; set; } = null!;
}
