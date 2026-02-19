using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_changeschedule
{
    public int workflowinstance_ptr_id { get; set; }

    public DateTime att_date { get; set; }

    public string? previous_timeinterval { get; set; }

    public DateTime apply_time { get; set; }

    public string? apply_reason { get; set; }

    public string? attachment { get; set; }

    public int timeinterval_id { get; set; }

    public virtual att_timeinterval timeinterval { get; set; } = null!;

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
