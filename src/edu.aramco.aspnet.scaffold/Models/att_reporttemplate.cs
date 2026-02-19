using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_reporttemplate
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string report { get; set; } = null!;

    public string template_name { get; set; } = null!;

    public string template_value { get; set; } = null!;

    public bool is_share { get; set; }

    public bool is_auto_export { get; set; }

    public bool fixed_date_period { get; set; }

    public string language { get; set; } = null!;

    public int? builder_id { get; set; }

    public int? employee_id { get; set; }

    public virtual auth_user? builder { get; set; }

    public virtual personnel_employee? employee { get; set; }
}
