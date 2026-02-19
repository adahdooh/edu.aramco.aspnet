using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitorconfig
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public short qr_code_policy { get; set; }

    public string code_prefix { get; set; } = null!;

    public int code_width { get; set; }

    public int code_start { get; set; }

    public string? access_limited { get; set; }

    public short auto_delete_data { get; set; }

    public int data_retention { get; set; }
}
