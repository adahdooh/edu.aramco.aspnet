using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminalemployee
{
    public int id { get; set; }

    public string terminal_sn { get; set; } = null!;

    public string emp_code { get; set; } = null!;

    public short privilege { get; set; }
}
