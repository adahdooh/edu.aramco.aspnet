using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attemployee
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public bool enable_attendance { get; set; }

    public bool enable_schedule { get; set; }

    public bool enable_overtime { get; set; }

    public bool enable_holiday { get; set; }

    public int emp_id { get; set; }

    public int? group_id { get; set; }

    public bool enable_compensatory { get; set; }

    public string? ip_address { get; set; }

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual att_attgroup? group { get; set; }
}
