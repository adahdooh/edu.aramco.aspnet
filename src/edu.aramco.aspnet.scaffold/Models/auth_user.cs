using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class auth_user
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public string password { get; set; } = null!;

    public DateTime? update_time { get; set; }

    public string first_name { get; set; } = null!;

    public string last_name { get; set; } = null!;

    public string? emp_pin { get; set; }

    public string email { get; set; } = null!;

    public string? tele_phone { get; set; }

    public int? auth_time_dept { get; set; }

    public int? login_id { get; set; }

    public int? login_type { get; set; }

    public int? login_count { get; set; }

    public bool is_staff { get; set; }

    public bool is_active { get; set; }

    public bool is_superuser { get; set; }

    public bool is_public { get; set; }

    public bool can_manage_all_dept { get; set; }

    public int? del_flag { get; set; }

    public DateTime date_joined { get; set; }

    public DateTime? last_login { get; set; }

    public string? session_key { get; set; }

    public string? login_ip { get; set; }

    public string? photo { get; set; }

    public int? assign_company { get; set; }

    public virtual ICollection<accounts_adminbiodatum> accounts_adminbiodata { get; set; } = new List<accounts_adminbiodatum>();

    public virtual ICollection<accounts_usernotification> accounts_usernotifications { get; set; } = new List<accounts_usernotification>();

    public virtual ICollection<att_reporttemplate> att_reporttemplates { get; set; } = new List<att_reporttemplate>();

    public virtual ICollection<auth_user_auth_area> auth_user_auth_areas { get; set; } = new List<auth_user_auth_area>();

    public virtual ICollection<auth_user_auth_dept> auth_user_auth_depts { get; set; } = new List<auth_user_auth_dept>();

    public virtual ICollection<auth_user_group> auth_user_groups { get; set; } = new List<auth_user_group>();

    public virtual auth_user_profile? auth_user_profile { get; set; }

    public virtual ICollection<auth_user_user_permission> auth_user_user_permissions { get; set; } = new List<auth_user_user_permission>();

    public virtual authtoken_token? authtoken_token { get; set; }

    public virtual ICollection<base_adminlog> base_adminlogs { get; set; } = new List<base_adminlog>();

    public virtual ICollection<base_bookmark> base_bookmarks { get; set; } = new List<base_bookmark>();

    public virtual ICollection<django_admin_log> django_admin_logs { get; set; } = new List<django_admin_log>();

    public virtual ICollection<guardian_userobjectpermission> guardian_userobjectpermissions { get; set; } = new List<guardian_userobjectpermission>();

    public virtual ICollection<mobile_announcement> mobile_announcements { get; set; } = new List<mobile_announcement>();

    public virtual ICollection<mobile_appnotification> mobile_appnotifications { get; set; } = new List<mobile_appnotification>();

    public virtual ICollection<rest_framework_tracking_apirequestlog> rest_framework_tracking_apirequestlogs { get; set; } = new List<rest_framework_tracking_apirequestlog>();
}
