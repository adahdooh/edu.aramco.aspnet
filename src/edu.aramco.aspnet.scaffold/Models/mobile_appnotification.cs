using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_appnotification
{
    public int id { get; set; }

    public string? sender { get; set; }

    public string? system_sender { get; set; }

    public short category { get; set; }

    public int? sub_category { get; set; }

    public string? content { get; set; }

    public string? payload { get; set; }

    public int? source { get; set; }

    public DateTime notification_time { get; set; }

    public short read_status { get; set; }

    public DateTime? read_time { get; set; }

    public int? admin_id { get; set; }

    public int? init_sender_id { get; set; }

    public int receiver_id { get; set; }

    public virtual auth_user? admin { get; set; }

    public virtual personnel_employee? init_sender { get; set; }

    public virtual personnel_employee receiver { get; set; } = null!;
}
