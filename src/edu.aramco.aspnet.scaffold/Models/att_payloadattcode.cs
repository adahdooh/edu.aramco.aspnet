using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_payloadattcode
{
    public string id { get; set; } = null!;

    public DateTime att_date { get; set; }

    public int week { get; set; }

    public int weekday { get; set; }

    public string att_code_alias { get; set; } = null!;

    public string? att_code_symbol { get; set; }

    public int duration { get; set; }

    public decimal workday { get; set; }

    public decimal hours { get; set; }

    public decimal minutes { get; set; }

    public bool is_weekly { get; set; }

    public int att_code_id { get; set; }

    public int emp_id { get; set; }

    public int? shift_id { get; set; }

    public string? time_card_id { get; set; }

    public virtual att_attcode att_code { get; set; } = null!;

    public virtual personnel_employee emp { get; set; } = null!;

    public virtual att_attshift? shift { get; set; }
}
