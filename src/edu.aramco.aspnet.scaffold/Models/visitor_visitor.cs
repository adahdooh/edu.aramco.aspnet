using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class visitor_visitor
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string visitor_code { get; set; } = null!;

    public string? first_name { get; set; }

    public string? last_name { get; set; }

    public string cert_no { get; set; } = null!;

    public string? photo { get; set; }

    public string? password { get; set; }

    public string? card_no { get; set; }

    public string? gender { get; set; }

    public string? company { get; set; }

    public string? ssn { get; set; }

    public DateTime? update_time { get; set; }

    public string? email { get; set; }

    public string? mobile { get; set; }

    public int visit_quantity { get; set; }

    public string? entry_carrying_goods { get; set; }

    public DateTime start_time { get; set; }

    public DateTime end_time { get; set; }

    public DateTime? exit_time { get; set; }

    public string? exit_carrying_goods { get; set; }

    public string? remark { get; set; }

    public int cert_type_id { get; set; }

    public int? visit_department_id { get; set; }

    public int? visit_reason_id { get; set; }

    public int visited_id { get; set; }

    public virtual personnel_certification cert_type { get; set; } = null!;

    public virtual personnel_department? visit_department { get; set; }

    public virtual visitor_reason? visit_reason { get; set; }

    public virtual personnel_employee visited { get; set; } = null!;

    public virtual ICollection<visitor_visitor_acc_group> visitor_visitor_acc_groups { get; set; } = new List<visitor_visitor_acc_group>();

    public virtual ICollection<visitor_visitor_area> visitor_visitor_areas { get; set; } = new List<visitor_visitor_area>();

    public virtual ICollection<visitor_visitorbiodatum> visitor_visitorbiodata { get; set; } = new List<visitor_visitorbiodatum>();

    public virtual ICollection<visitor_visitorbiophoto> visitor_visitorbiophotos { get; set; } = new List<visitor_visitorbiophoto>();

    public virtual ICollection<visitor_visitorlog> visitor_visitorlogs { get; set; } = new List<visitor_visitorlog>();

    public virtual ICollection<visitor_visitortransaction> visitor_visitortransactions { get; set; } = new List<visitor_visitortransaction>();
}
