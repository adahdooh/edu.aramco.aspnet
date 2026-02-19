using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attcalclog
{
    public int id { get; set; }

    public int? dept_id { get; set; }

    public int? emp_id { get; set; }

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public DateTime update_time { get; set; }

    public int log_type { get; set; }
}
