using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class authtoken_token
{
    public string key { get; set; } = null!;

    public DateTime created { get; set; }

    public int user_id { get; set; }

    public virtual auth_user user { get; set; } = null!;
}
