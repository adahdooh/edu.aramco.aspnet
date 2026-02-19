using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_leave
{
    public int workflowinstance_ptr_id { get; set; }

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public string? apply_reason { get; set; }

    public DateTime apply_time { get; set; }

    public string? attachment { get; set; }

    public double leave_day { get; set; }

    public int? pay_code_id { get; set; }

    public virtual ICollection<att_payloadexception> att_payloadexceptions { get; set; } = new List<att_payloadexception>();

    public virtual att_paycode? pay_code { get; set; }

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
