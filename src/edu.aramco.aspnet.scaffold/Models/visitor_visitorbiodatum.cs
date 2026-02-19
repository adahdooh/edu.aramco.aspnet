using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitorbiodatum
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string bio_tmp { get; set; } = null!;

    public int? bio_no { get; set; }

    public int? bio_index { get; set; }

    public int bio_type { get; set; }

    public string major_ver { get; set; } = null!;

    public string? minor_ver { get; set; }

    public int? bio_format { get; set; }

    public int valid { get; set; }

    public int duress { get; set; }

    public DateTime? update_time { get; set; }

    public string? sn { get; set; }

    public int visitor_id { get; set; }

    public virtual visitor_visitor visitor { get; set; } = null!;
}
