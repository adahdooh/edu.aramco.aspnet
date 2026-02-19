using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_securitypolicy
{
    public int id { get; set; }

    public bool single_login { get; set; }

    public bool app_single_user_login { get; set; }

    public bool security_code { get; set; }

    public int code_length { get; set; }

    public int valid_duration { get; set; }

    public bool failed_locked { get; set; }

    public int lock_failed_count { get; set; }

    public int lock_duration { get; set; }

    public bool enforce_pwd_change { get; set; }

    public bool enforce_pwd_expiration { get; set; }

    public int validity_period { get; set; }

    public short password_level { get; set; }

    public bool is_default { get; set; }

    public int session_timeout { get; set; }

    public bool export_encryption { get; set; }

    public string? export_encryption_password { get; set; }

    public bool app_single_device_login { get; set; }
}
