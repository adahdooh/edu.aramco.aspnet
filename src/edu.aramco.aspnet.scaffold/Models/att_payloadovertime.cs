using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadovertime
{
    public string uuid { get; set; } = null!;

    public int? normal_wt { get; set; }

    public int? normal_ot { get; set; }

    public int? weekend_ot { get; set; }

    public int? holiday_ot { get; set; }

    public int? ot_lv1 { get; set; }

    public int? ot_lv2 { get; set; }

    public int? ot_lv3 { get; set; }

    public int? total_ot { get; set; }
}
