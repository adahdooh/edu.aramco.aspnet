using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class acc_accprivilege
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public short is_group_timezone { get; set; }

    public int? timezone1 { get; set; }

    public int? timezone2 { get; set; }

    public int? timezone3 { get; set; }

    public short is_group_verifycode { get; set; }

    public int? verify_mode { get; set; }

    public DateTime? update_time { get; set; }

    public int area_id { get; set; }

    public int employee_id { get; set; }

    public int group_id { get; set; }

    public virtual personnel_area area { get; set; } = null!;

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual acc_accgroup group { get; set; } = null!;
}
