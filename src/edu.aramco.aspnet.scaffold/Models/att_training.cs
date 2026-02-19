using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_training
{
    public int workflowinstance_ptr_id { get; set; }

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public DateTime apply_time { get; set; }

    public string? apply_reason { get; set; }

    public string? attachment { get; set; }

    public int? pay_code_id { get; set; }

    public virtual att_paycode? pay_code { get; set; }

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
