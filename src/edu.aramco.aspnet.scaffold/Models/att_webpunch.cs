using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_webpunch
{
    public int workflowinstance_ptr_id { get; set; }

    public DateTime punch_time { get; set; }

    public string punch_state { get; set; } = null!;

    public string? work_code { get; set; }

    public string? apply_reason { get; set; }

    public DateTime apply_time { get; set; }

    public int verify_type { get; set; }

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
