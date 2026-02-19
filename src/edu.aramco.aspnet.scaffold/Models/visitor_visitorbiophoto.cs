using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitorbiophoto
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string? first_name { get; set; }

    public string? last_name { get; set; }

    public string? email { get; set; }

    public string? enroll_sn { get; set; }

    public string register_photo { get; set; } = null!;

    public DateTime register_time { get; set; }

    public string? approval_photo { get; set; }

    public short approval_state { get; set; }

    public DateTime? approval_time { get; set; }

    public string? remark { get; set; }

    public int visitor_id { get; set; }

    public virtual visitor_visitor visitor { get; set; } = null!;
}
