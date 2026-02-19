using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_deptattrule
{
    public int id { get; set; }

    public string alias { get; set; } = null!;

    public string? rule { get; set; }

    public int department_id { get; set; }

    public virtual personnel_department department { get; set; } = null!;
}
