using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_dbbackuplog
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string db_type { get; set; } = null!;

    public string db_name { get; set; } = null!;

    public string? _operator { get; set; }

    public string backup_file { get; set; } = null!;

    public DateTime backup_time { get; set; }

    public short backup_status { get; set; }

    public string? remark { get; set; }
}
