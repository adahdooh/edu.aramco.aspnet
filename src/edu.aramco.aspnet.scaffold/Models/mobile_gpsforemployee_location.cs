using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_gpsforemployee_location
{
    public int id { get; set; }

    public int gpsforemployee_id { get; set; }

    public int gpslocation_id { get; set; }

    public virtual mobile_gpsforemployee gpsforemployee { get; set; } = null!;

    public virtual mobile_gpslocation gpslocation { get; set; } = null!;
}
