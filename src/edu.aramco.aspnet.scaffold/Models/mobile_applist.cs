using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_applist
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public DateTime login_time { get; set; }

    public DateTime last_active { get; set; }

    public string token { get; set; } = null!;

    public string device_token { get; set; } = null!;

    public string client_id { get; set; } = null!;

    public short client_category { get; set; }

    public short? active { get; set; }

    public short? enable { get; set; }
}
