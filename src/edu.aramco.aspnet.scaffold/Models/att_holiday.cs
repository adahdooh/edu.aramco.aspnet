using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_holiday
{
    public int id { get; set; }

    public string alias { get; set; } = null!;

    public DateTime start_date { get; set; }

    public short duration_day { get; set; }

    public bool enable_ot_rule { get; set; }

    public string? ot_rule { get; set; }

    public string? color_setting { get; set; }

    public int? att_group_id { get; set; }

    public int? department_id { get; set; }

    public DateTime end_date { get; set; }

    public virtual ICollection<acc_accholiday> acc_accholidays { get; set; } = new List<acc_accholiday>();

    public virtual att_attgroup? att_group { get; set; }

    public virtual personnel_department? department { get; set; }
}
