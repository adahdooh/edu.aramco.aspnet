using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_workflownode
{
    public int id { get; set; }

    public string node_name { get; set; } = null!;

    public int order_id { get; set; }

    public bool approver_by_overall { get; set; }

    public bool notify_by_overall { get; set; }

    public int? workflow_engine_id { get; set; }

    public virtual workflow_workflowengine? workflow_engine { get; set; }

    public virtual ICollection<workflow_nodeinstance> workflow_nodeinstances { get; set; } = new List<workflow_nodeinstance>();

    public virtual ICollection<workflow_workflownode_approver> workflow_workflownode_approvers { get; set; } = new List<workflow_workflownode_approver>();

    public virtual ICollection<workflow_workflownode_notifier> workflow_workflownode_notifiers { get; set; } = new List<workflow_workflownode_notifier>();
}
