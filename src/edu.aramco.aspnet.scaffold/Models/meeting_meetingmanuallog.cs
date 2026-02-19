using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingmanuallog
{
    public int workflowinstance_ptr_id { get; set; }

    public DateTime punch_time { get; set; }

    public string punch_state { get; set; } = null!;

    public string apply_reason { get; set; } = null!;

    public DateTime apply_time { get; set; }

    public int? meeting_id { get; set; }

    public virtual meeting_meetingentity? meeting { get; set; }

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
