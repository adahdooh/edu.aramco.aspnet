using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_area
{
    public int id { get; set; }

    public string area_code { get; set; } = null!;

    public string area_name { get; set; } = null!;

    public bool is_default { get; set; }

    public int? parent_area_id { get; set; }

    public int device_count { get; set; }

    public int employee_count { get; set; }

    public int? company_id { get; set; }

    public virtual ICollection<personnel_area> Inverseparent_area { get; set; } = new List<personnel_area>();

    public virtual ICollection<acc_acccombination> acc_acccombinations { get; set; } = new List<acc_acccombination>();

    public virtual ICollection<acc_accgroup> acc_accgroups { get; set; } = new List<acc_accgroup>();

    public virtual ICollection<acc_accholiday> acc_accholidays { get; set; } = new List<acc_accholiday>();

    public virtual ICollection<acc_accprivilege> acc_accprivileges { get; set; } = new List<acc_accprivilege>();

    public virtual ICollection<acc_acctimezone> acc_acctimezones { get; set; } = new List<acc_acctimezone>();

    public virtual ICollection<auth_user_auth_area> auth_user_auth_areas { get; set; } = new List<auth_user_auth_area>();

    public virtual personnel_company? company { get; set; }

    public virtual ICollection<iclock_terminal> iclock_terminals { get; set; } = new List<iclock_terminal>();

    public virtual personnel_area? parent_area { get; set; }

    public virtual ICollection<personnel_assignareaemployee> personnel_assignareaemployees { get; set; } = new List<personnel_assignareaemployee>();

    public virtual ICollection<personnel_employee_area> personnel_employee_areas { get; set; } = new List<personnel_employee_area>();

    public virtual ICollection<visitor_visitor_area> visitor_visitor_areas { get; set; } = new List<visitor_visitor_area>();
}
