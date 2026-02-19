using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_gpsfordepartment_location
{
    public int id { get; set; }

    public int gpsfordepartment_id { get; set; }

    public int gpslocation_id { get; set; }

    public virtual mobile_gpsfordepartment gpsfordepartment { get; set; } = null!;

    public virtual mobile_gpslocation gpslocation { get; set; } = null!;
}
