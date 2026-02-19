using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_emailtemplate
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public int category { get; set; }

    public int sub_category { get; set; }

    public int _event { get; set; }

    public int receiver { get; set; }

    public string? subject { get; set; }

    public string template { get; set; } = null!;

    public bool enable { get; set; }
}
