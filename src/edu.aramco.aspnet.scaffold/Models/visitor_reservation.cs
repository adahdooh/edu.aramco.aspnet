using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_reservation
{
    public int workflowinstance_ptr_id { get; set; }

    public string? vis_first_name { get; set; }

    public string? vis_last_name { get; set; }

    public string cert_no { get; set; } = null!;

    public string? gender { get; set; }

    public string? company { get; set; }

    public DateTime? update_time { get; set; }

    public int visit_quantity { get; set; }

    public DateTime visit_date { get; set; }

    public DateTime apply_time { get; set; }

    public string? apply_reason { get; set; }

    public string? email { get; set; }

    public int cert_type_id { get; set; }

    public int? visit_department_id { get; set; }

    public int? visit_reason_id { get; set; }

    public virtual personnel_certification cert_type { get; set; } = null!;

    public virtual personnel_department? visit_department { get; set; }

    public virtual visitor_reason? visit_reason { get; set; }

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
