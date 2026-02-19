using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_company
{
    public int id { get; set; }

    public string company_code { get; set; } = null!;

    public string company_name { get; set; } = null!;

    public bool is_default { get; set; }

    public virtual ICollection<base_autoimporttask> base_autoimporttasks { get; set; } = new List<base_autoimporttask>();

    public virtual ICollection<iclock_terminalworkcode> iclock_terminalworkcodes { get; set; } = new List<iclock_terminalworkcode>();

    public virtual ICollection<personnel_area> personnel_areas { get; set; } = new List<personnel_area>();

    public virtual ICollection<personnel_department> personnel_departments { get; set; } = new List<personnel_department>();

    public virtual ICollection<personnel_employee> personnel_employees { get; set; } = new List<personnel_employee>();

    public virtual ICollection<personnel_position> personnel_positions { get; set; } = new List<personnel_position>();
}
