using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_department
{
    public int id { get; set; }

    public string dept_code { get; set; } = null!;

    public string dept_name { get; set; } = null!;

    public bool is_default { get; set; }

    public int? parent_dept_id { get; set; }

    public int? dept_manager_id { get; set; }

    public int? company_id { get; set; }

    public virtual ICollection<personnel_department> Inverseparent_dept { get; set; } = new List<personnel_department>();

    public virtual ICollection<att_departmentpolicy> att_departmentpolicies { get; set; } = new List<att_departmentpolicy>();

    public virtual ICollection<att_departmentschedule> att_departmentschedules { get; set; } = new List<att_departmentschedule>();

    public virtual ICollection<att_deptattrule> att_deptattrules { get; set; } = new List<att_deptattrule>();

    public virtual ICollection<att_holiday> att_holidays { get; set; } = new List<att_holiday>();

    public virtual ICollection<auth_user_auth_dept> auth_user_auth_depts { get; set; } = new List<auth_user_auth_dept>();

    public virtual ICollection<base_linenotifysetting> base_linenotifysettings { get; set; } = new List<base_linenotifysetting>();

    public virtual personnel_company? company { get; set; }

    public virtual personnel_employee? dept_manager { get; set; }

    public virtual ICollection<mobile_gpsfordepartment> mobile_gpsfordepartments { get; set; } = new List<mobile_gpsfordepartment>();

    public virtual personnel_department? parent_dept { get; set; }

    public virtual ICollection<personnel_employee> personnel_employees { get; set; } = new List<personnel_employee>();

    public virtual ICollection<visitor_reservation> visitor_reservations { get; set; } = new List<visitor_reservation>();

    public virtual ICollection<visitor_visitor> visitor_visitors { get; set; } = new List<visitor_visitor>();

    public virtual ICollection<workflow_workflowengine> workflow_workflowengines { get; set; } = new List<workflow_workflowengine>();
}
