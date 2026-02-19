using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingroom
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string code { get; set; } = null!;

    public string alias { get; set; } = null!;

    public int capacity { get; set; }

    public string location { get; set; } = null!;

    public string? remark { get; set; }

    public short state { get; set; }

    public bool enable_room { get; set; }

    public virtual ICollection<meeting_meetingentity> meeting_meetingentities { get; set; } = new List<meeting_meetingentity>();

    public virtual ICollection<meeting_meetingroomdevice> meeting_meetingroomdevices { get; set; } = new List<meeting_meetingroomdevice>();
}
