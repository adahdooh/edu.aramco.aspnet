using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingentity
{
    public int workflowinstance_ptr_id { get; set; }

    public string code { get; set; } = null!;

    public string alias { get; set; } = null!;

    public string? content { get; set; }

    public DateTime meeting_date { get; set; }

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public int duration { get; set; }

    public bool in_required { get; set; }

    public DateTime in_start { get; set; }

    public DateTime in_end { get; set; }

    public bool out_required { get; set; }

    public DateTime out_start { get; set; }

    public DateTime out_end { get; set; }

    public bool enable_virtual { get; set; }

    public string? virutal_uuid { get; set; }

    public short time_zone { get; set; }

    public string? preferences { get; set; }

    public string? link_data { get; set; }

    public string apply_reason { get; set; } = null!;

    public DateTime apply_time { get; set; }

    public DateTime? calculation_time { get; set; }

    public DateTime? sync_time { get; set; }

    public DateTime view_date { get; set; }

    public bool host_video { get; set; }

    public bool participant_video { get; set; }

    public bool enable_waiting_room { get; set; }

    public bool jbh_anytime { get; set; }

    public bool mute_upon_entry { get; set; }

    public string auto_recording { get; set; } = null!;

    public int? room_id { get; set; }

    public virtual ICollection<meeting_meetingentity_attender> meeting_meetingentity_attenders { get; set; } = new List<meeting_meetingentity_attender>();

    public virtual ICollection<meeting_meetingmanuallog> meeting_meetingmanuallogs { get; set; } = new List<meeting_meetingmanuallog>();

    public virtual ICollection<meeting_meetingpayloadbase> meeting_meetingpayloadbases { get; set; } = new List<meeting_meetingpayloadbase>();

    public virtual ICollection<meeting_meetingtransaction> meeting_meetingtransactions { get; set; } = new List<meeting_meetingtransaction>();

    public virtual meeting_meetingroom? room { get; set; }

    public virtual workflow_workflowinstance workflowinstance_ptr { get; set; } = null!;
}
