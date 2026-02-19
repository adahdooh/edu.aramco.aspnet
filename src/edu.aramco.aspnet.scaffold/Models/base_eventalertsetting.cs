using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_eventalertsetting
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int event_id { get; set; }

    public string _event { get; set; } = null!;

    public string module { get; set; } = null!;

    public string sub_module { get; set; } = null!;

    public bool email_alert { get; set; }

    public bool app_alert { get; set; }

    public bool sms_alert { get; set; }

    public bool whatapp_alert { get; set; }
}
