using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class accounts_adminbiodatum
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

    public bool valid { get; set; }

    public bool duress { get; set; }

    public int admin_id { get; set; }

    public virtual auth_user admin { get; set; } = null!;
}
