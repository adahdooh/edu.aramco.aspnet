using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attgroup
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string code { get; set; } = null!;

    public string name { get; set; } = null!;

    public virtual ICollection<att_attemployee> att_attemployees { get; set; } = new List<att_attemployee>();

    public virtual ICollection<att_grouppolicy> att_grouppolicies { get; set; } = new List<att_grouppolicy>();

    public virtual ICollection<att_groupschedule> att_groupschedules { get; set; } = new List<att_groupschedule>();

    public virtual ICollection<att_holiday> att_holidays { get; set; } = new List<att_holiday>();
}
