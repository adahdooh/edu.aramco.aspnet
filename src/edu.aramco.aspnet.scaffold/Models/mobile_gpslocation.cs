using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_gpslocation
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string alias { get; set; } = null!;

    public string location { get; set; } = null!;

    public double longitude { get; set; }

    public double latitude { get; set; }

    public virtual ICollection<mobile_gpsfordepartment_location> mobile_gpsfordepartment_locations { get; set; } = new List<mobile_gpsfordepartment_location>();

    public virtual ICollection<mobile_gpsforemployee_location> mobile_gpsforemployee_locations { get; set; } = new List<mobile_gpsforemployee_location>();
}
