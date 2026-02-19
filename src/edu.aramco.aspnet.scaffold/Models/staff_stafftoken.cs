using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class staff_stafftoken
{
    public string key { get; set; } = null!;

    public DateTime created { get; set; }

    public int user_id { get; set; }

    public virtual personnel_employee user { get; set; } = null!;
}
