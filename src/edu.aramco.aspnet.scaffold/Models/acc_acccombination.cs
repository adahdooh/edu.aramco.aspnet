using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class acc_acccombination
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int combination_no { get; set; }

    public string combination_name { get; set; } = null!;

    public int? group1 { get; set; }

    public int? group2 { get; set; }

    public int? group3 { get; set; }

    public int? group4 { get; set; }

    public int? group5 { get; set; }

    public string? remark { get; set; }

    public DateTime? update_time { get; set; }

    public int area_id { get; set; }

    public virtual personnel_area area { get; set; } = null!;
}
