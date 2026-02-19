using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class meeting_meetingentity_attender
{
    public int id { get; set; }

    public int meetingentity_id { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual meeting_meetingentity meetingentity { get; set; } = null!;
}
