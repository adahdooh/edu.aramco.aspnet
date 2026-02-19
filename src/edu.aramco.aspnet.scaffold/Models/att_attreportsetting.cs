using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attreportsetting
{
    public int id { get; set; }

    public bool filter_by_hire_date { get; set; }

    public short resign_emp { get; set; }

    public short short_date { get; set; }

    public short short_time { get; set; }

    public bool auto_calculate { get; set; }

    public DateTime? calculate_time { get; set; }
}
