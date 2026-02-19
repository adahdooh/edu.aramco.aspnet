using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_tempschedule
{
    public int id { get; set; }

    public DateTime? att_date { get; set; }

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public short rule_flag { get; set; }

    public short work_type { get; set; }

    public int employee_id { get; set; }

    public int? time_interval_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;
}
