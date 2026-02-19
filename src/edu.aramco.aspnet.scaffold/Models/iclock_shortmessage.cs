using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_shortmessage
{
    public int id { get; set; }

    public string message { get; set; } = null!;

    public DateTime start_time { get; set; }

    public int duration { get; set; }

    public string msg_type { get; set; } = null!;

    public virtual ICollection<iclock_privatemessage> iclock_privatemessages { get; set; } = new List<iclock_privatemessage>();

    public virtual ICollection<iclock_publicmessage> iclock_publicmessages { get; set; } = new List<iclock_publicmessage>();
}
