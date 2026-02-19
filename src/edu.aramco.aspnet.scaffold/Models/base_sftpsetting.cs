using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_sftpsetting
{
    public int id { get; set; }

    public string host { get; set; } = null!;

    public int port { get; set; }

    public short is_sftp { get; set; }

    public string user_name { get; set; } = null!;

    public string? user_password { get; set; }

    public string? user_key { get; set; }
}
