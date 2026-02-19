using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class sync_employee
{
    public int id { get; set; }

    public DateTime? post_time { get; set; }

    public short flag { get; set; }

    public DateTime? update_time { get; set; }

    public string? sync_ret { get; set; }

    public string emp_code { get; set; } = null!;

    public string? first_name { get; set; }

    public string? last_name { get; set; }

    public string? dept_code { get; set; }

    public string? dept_name { get; set; }

    public string? job_code { get; set; }

    public string? job_name { get; set; }

    public string? area_code { get; set; }

    public string? area_name { get; set; }

    public string? card_no { get; set; }

    public bool multi_area { get; set; }

    public DateTime? hire_date { get; set; }

    public string? gender { get; set; }

    public DateTime? birthday { get; set; }

    public string? email { get; set; }

    public bool active_status { get; set; }
}
