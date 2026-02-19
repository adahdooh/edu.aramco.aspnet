using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class acc_accgroup
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int group_no { get; set; }

    public string group_name { get; set; } = null!;

    public int verify_mode { get; set; }

    public int? timezone1 { get; set; }

    public int? timezone2 { get; set; }

    public int? timezone3 { get; set; }

    public short is_include_holiday { get; set; }

    public DateTime? update_time { get; set; }

    public int area_id { get; set; }

    public virtual ICollection<acc_accprivilege> acc_accprivileges { get; set; } = new List<acc_accprivilege>();

    public virtual personnel_area area { get; set; } = null!;

    public virtual ICollection<visitor_visitor_acc_group> visitor_visitor_acc_groups { get; set; } = new List<visitor_visitor_acc_group>();
}
