using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadexception
{
    public string uuid { get; set; } = null!;

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public int? duration { get; set; }

    public double? days { get; set; }

    public short data_type { get; set; }

    public string? description { get; set; }

    public int? item_id { get; set; }

    public string? skd_id { get; set; }

    public virtual att_leave? item { get; set; }
}
