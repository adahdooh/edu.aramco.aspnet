using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_nodeinstance
{
    public int id { get; set; }

    public string node_name { get; set; } = null!;

    public int order_id { get; set; }

    public short approval_status { get; set; }

    public DateTime? approval_time { get; set; }

    public string? approval_remark { get; set; }

    public bool active { get; set; }

    public bool targeted { get; set; }

    public int? approver_employee_id { get; set; }

    public int? workflow_instance_id { get; set; }

    public int? workflow_node_id { get; set; }

    public virtual personnel_employee? approver_employee { get; set; }

    public virtual workflow_workflowinstance? workflow_instance { get; set; }

    public virtual workflow_workflownode? workflow_node { get; set; }
}
