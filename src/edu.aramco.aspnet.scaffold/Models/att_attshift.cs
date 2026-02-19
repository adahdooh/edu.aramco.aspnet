using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attshift
{
    public int id { get; set; }

    public string alias { get; set; } = null!;

    public short cycle_unit { get; set; }

    public int shift_cycle { get; set; }

    public bool work_weekend { get; set; }

    public short weekend_type { get; set; }

    public bool work_day_off { get; set; }

    public short day_off_type { get; set; }

    public short auto_shift { get; set; }

    public bool enable_ot_rule { get; set; }

    public short frequency { get; set; }

    public string? ot_rule { get; set; }

    public virtual ICollection<att_attschedule> att_attschedules { get; set; } = new List<att_attschedule>();

    public virtual ICollection<att_departmentschedule> att_departmentschedules { get; set; } = new List<att_departmentschedule>();

    public virtual ICollection<att_groupschedule> att_groupschedules { get; set; } = new List<att_groupschedule>();

    public virtual ICollection<att_payloadattcode> att_payloadattcodes { get; set; } = new List<att_payloadattcode>();

    public virtual ICollection<att_payloadpaycode> att_payloadpaycodes { get; set; } = new List<att_payloadpaycode>();

    public virtual ICollection<att_shiftdetail> att_shiftdetails { get; set; } = new List<att_shiftdetail>();
}
