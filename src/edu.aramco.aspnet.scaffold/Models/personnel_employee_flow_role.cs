using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employee_flow_role
{
    public int id { get; set; }

    public int employee_id { get; set; }

    public int workflowrole_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual workflow_workflowrole workflowrole { get; set; } = null!;
}
