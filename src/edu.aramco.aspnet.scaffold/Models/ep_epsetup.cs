using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class ep_epsetup
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public bool temp_alarm { get; set; }

    public decimal temp_warning { get; set; }

    public decimal? temp_warning_F { get; set; }

    public short temp_unit { get; set; }

    public bool mask_alarm { get; set; }

    public bool is_default { get; set; }
}
