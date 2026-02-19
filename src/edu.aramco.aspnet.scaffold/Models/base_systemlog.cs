using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_systemlog
{
    public int id { get; set; }

    public DateTime execute_time { get; set; }

    public short operation { get; set; }

    public short execute_status { get; set; }

    public string? description { get; set; }
}
