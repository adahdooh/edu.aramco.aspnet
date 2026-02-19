using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class workflow_workflowinstance
{
    public int id { get; set; }

    public DateTime? approval_time { get; set; }

    public short approval_status { get; set; }

    public string? approval_remark { get; set; }

    public string? approver { get; set; }

    public string? approver_instance { get; set; }

    public int employee_id { get; set; }

    public int? workflow_engine_id { get; set; }

    public virtual att_changeschedule? att_changeschedule { get; set; }

    public virtual att_leave? att_leave { get; set; }

    public virtual att_manuallog? att_manuallog { get; set; }

    public virtual att_overtime? att_overtime { get; set; }

    public virtual att_training? att_training { get; set; }

    public virtual att_webpunch? att_webpunch { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual meeting_meetingentity? meeting_meetingentity { get; set; }

    public virtual meeting_meetingmanuallog? meeting_meetingmanuallog { get; set; }

    public virtual visitor_reservation? visitor_reservation { get; set; }

    public virtual workflow_workflowengine? workflow_engine { get; set; }

    public virtual ICollection<workflow_nodeinstance> workflow_nodeinstances { get; set; } = new List<workflow_nodeinstance>();
}
