using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_gpsforemployee
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int distance { get; set; }

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual ICollection<mobile_gpsforemployee_location> mobile_gpsforemployee_locations { get; set; } = new List<mobile_gpsforemployee_location>();
}
