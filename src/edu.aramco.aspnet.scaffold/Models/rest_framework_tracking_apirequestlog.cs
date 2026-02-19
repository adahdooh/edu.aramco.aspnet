using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class rest_framework_tracking_apirequestlog
{
    public int id { get; set; }

    public DateTime requested_at { get; set; }

    public int response_ms { get; set; }

    public string path { get; set; } = null!;

    public string remote_addr { get; set; } = null!;

    public string host { get; set; } = null!;

    public string method { get; set; } = null!;

    public string? query_params { get; set; }

    public string? data { get; set; }

    public string? response { get; set; }

    public int? status_code { get; set; }

    public int? user_id { get; set; }

    public string? view { get; set; }

    public string? view_method { get; set; }

    public string? errors { get; set; }

    public string? username_persistent { get; set; }

    public virtual auth_user? user { get; set; }
}
