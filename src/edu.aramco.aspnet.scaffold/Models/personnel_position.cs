using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_position
{
    public int id { get; set; }

    public string position_code { get; set; } = null!;

    public string position_name { get; set; } = null!;

    public bool is_default { get; set; }

    public int? parent_position_id { get; set; }

    public int? company_id { get; set; }

    public virtual ICollection<personnel_position> Inverseparent_position { get; set; } = new List<personnel_position>();

    public virtual personnel_company? company { get; set; }

    public virtual personnel_position? parent_position { get; set; }

    public virtual ICollection<personnel_employee> personnel_employees { get; set; } = new List<personnel_employee>();

    public virtual ICollection<workflow_workflowengine> workflow_workflowengines { get; set; } = new List<workflow_workflowengine>();
}
