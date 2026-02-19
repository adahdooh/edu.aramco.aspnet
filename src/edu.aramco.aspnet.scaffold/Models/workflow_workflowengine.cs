using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_workflowengine
{
    public int id { get; set; }

    public string workflow_code { get; set; } = null!;

    public string workflow_name { get; set; } = null!;

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public string description { get; set; } = null!;

    public short workflow_type { get; set; }

    public int? applicant_position_id { get; set; }

    public int? content_type_id { get; set; }

    public int? departments_id { get; set; }

    public virtual personnel_position? applicant_position { get; set; }

    public virtual django_content_type? content_type { get; set; }

    public virtual personnel_department? departments { get; set; }

    public virtual ICollection<workflow_workflowengine_employee> workflow_workflowengine_employees { get; set; } = new List<workflow_workflowengine_employee>();

    public virtual ICollection<workflow_workflowinstance> workflow_workflowinstances { get; set; } = new List<workflow_workflowinstance>();

    public virtual ICollection<workflow_workflownode> workflow_workflownodes { get; set; } = new List<workflow_workflownode>();
}
