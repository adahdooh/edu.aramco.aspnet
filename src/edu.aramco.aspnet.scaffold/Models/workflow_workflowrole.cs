using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_workflowrole
{
    public int id { get; set; }

    public string role_code { get; set; } = null!;

    public string role_name { get; set; } = null!;

    public string? description { get; set; }

    public virtual ICollection<personnel_employee_flow_role> personnel_employee_flow_roles { get; set; } = new List<personnel_employee_flow_role>();

    public virtual ICollection<workflow_workflownode_approver> workflow_workflownode_approvers { get; set; } = new List<workflow_workflownode_approver>();

    public virtual ICollection<workflow_workflownode_notifier> workflow_workflownode_notifiers { get; set; } = new List<workflow_workflownode_notifier>();
}
