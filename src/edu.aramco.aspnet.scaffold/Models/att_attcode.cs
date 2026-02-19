using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_attcode
{
    public int id { get; set; }

    public string code { get; set; } = null!;

    public string alias { get; set; } = null!;

    public short display_format { get; set; }

    public string symbol { get; set; } = null!;

    public short round_off { get; set; }

    public decimal min_val { get; set; }

    public bool symbol_only { get; set; }

    public short order { get; set; }

    public string? color_setting { get; set; }

    public virtual ICollection<att_payloadattcode> att_payloadattcodes { get; set; } = new List<att_payloadattcode>();
}
