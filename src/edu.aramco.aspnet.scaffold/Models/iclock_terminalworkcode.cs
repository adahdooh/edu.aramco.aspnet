using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminalworkcode
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string code { get; set; } = null!;

    public string alias { get; set; } = null!;

    public DateTime? last_activity { get; set; }

    public int? company_id { get; set; }

    public virtual personnel_company? company { get; set; }
}
