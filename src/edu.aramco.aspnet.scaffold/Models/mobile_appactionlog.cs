using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_appactionlog
{
    public int id { get; set; }

    public string user { get; set; } = null!;

    public string? client { get; set; }

    public string? action { get; set; }

    public string? _params { get; set; }

    public string? describe { get; set; }

    public short request_status { get; set; }

    public DateTime action_time { get; set; }

    public string? remote_ip { get; set; }
}
