using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class sync_job
{
    public int id { get; set; }

    public DateTime? post_time { get; set; }

    public short flag { get; set; }

    public DateTime? update_time { get; set; }

    public string? sync_ret { get; set; }

    public string job_code { get; set; } = null!;

    public string job_name { get; set; } = null!;
}
