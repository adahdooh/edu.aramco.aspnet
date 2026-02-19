using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class accounts_usernotification
{
    public int id { get; set; }

    public int? category { get; set; }

    public int? _event { get; set; }

    public string content { get; set; } = null!;

    public DateTime send_time { get; set; }

    public DateTime? read_time { get; set; }

    public short status { get; set; }

    public int user_id { get; set; }

    public virtual auth_user user { get; set; } = null!;
}
