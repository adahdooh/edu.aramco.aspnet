using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingroomdevice
{
    public int id { get; set; }

    public int device_id { get; set; }

    public int? room_id { get; set; }

    public virtual iclock_terminal device { get; set; } = null!;

    public virtual meeting_meetingroom? room { get; set; }
}
