using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class acc_acctimezone
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int timezone_no { get; set; }

    public string timezone_name { get; set; } = null!;

    public DateTime sun_start { get; set; }

    public DateTime sun_end { get; set; }

    public short? sun_on { get; set; }

    public DateTime mon_start { get; set; }

    public DateTime mon_end { get; set; }

    public short? mon_on { get; set; }

    public DateTime tue_start { get; set; }

    public DateTime tue_end { get; set; }

    public short? tue_on { get; set; }

    public DateTime wed_start { get; set; }

    public DateTime wed_end { get; set; }

    public short? wed_on { get; set; }

    public DateTime thu_start { get; set; }

    public DateTime thu_end { get; set; }

    public short? thu_on { get; set; }

    public DateTime fri_start { get; set; }

    public DateTime fri_end { get; set; }

    public short? fri_on { get; set; }

    public DateTime sat_start { get; set; }

    public DateTime sat_end { get; set; }

    public short? sat_on { get; set; }

    public string? remark { get; set; }

    public DateTime? update_time { get; set; }

    public int area_id { get; set; }

    public virtual ICollection<acc_accholiday> acc_accholidays { get; set; } = new List<acc_accholiday>();

    public virtual personnel_area area { get; set; } = null!;
}
