using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_workflownode_notifier
{
    public int id { get; set; }

    public int workflownode_id { get; set; }

    public int workflowrole_id { get; set; }

    public virtual workflow_workflownode workflownode { get; set; } = null!;

    public virtual workflow_workflowrole workflowrole { get; set; } = null!;
}
