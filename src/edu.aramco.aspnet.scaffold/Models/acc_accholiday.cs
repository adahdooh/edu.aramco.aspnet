using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class acc_accholiday
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public DateTime? update_time { get; set; }

    public int area_id { get; set; }

    public int holiday_id { get; set; }

    public int timezone_id { get; set; }

    public virtual personnel_area area { get; set; } = null!;

    public virtual att_holiday holiday { get; set; } = null!;

    public virtual acc_acctimezone timezone { get; set; } = null!;
}
