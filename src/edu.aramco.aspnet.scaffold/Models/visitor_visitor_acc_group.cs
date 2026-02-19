using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitor_acc_group
{
    public int id { get; set; }

    public int visitor_id { get; set; }

    public int accgroups_id { get; set; }

    public virtual acc_accgroup accgroups { get; set; } = null!;

    public virtual visitor_visitor visitor { get; set; } = null!;
}
