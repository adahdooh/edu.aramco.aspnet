using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_whatsapplog
{
    public int id { get; set; }

    public string receiver { get; set; } = null!;

    public string content { get; set; } = null!;

    public short result { get; set; }

    public DateTime push_time { get; set; }

    public string reason { get; set; } = null!;
}
