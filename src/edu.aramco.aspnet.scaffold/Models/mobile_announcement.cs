using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class mobile_announcement
{
    public int id { get; set; }

    public string subject { get; set; } = null!;

    public string content { get; set; } = null!;

    public short category { get; set; }

    public string? sender { get; set; }

    public string? system_sender { get; set; }

    public DateTime? create_time { get; set; }

    public int? admin_id { get; set; }

    public int? init_sender_id { get; set; }

    public int? receiver_id { get; set; }

    public virtual auth_user? admin { get; set; }

    public virtual personnel_employee? init_sender { get; set; }

    public virtual personnel_employee? receiver { get; set; }
}
