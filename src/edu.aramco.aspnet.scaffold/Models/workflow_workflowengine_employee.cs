using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_workflowengine_employee
{
    public int id { get; set; }

    public int workflowengine_id { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual workflow_workflowengine workflowengine { get; set; } = null!;
}
