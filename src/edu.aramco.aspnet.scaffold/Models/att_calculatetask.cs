using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class att_calculatetask
{
    public int id { get; set; }

    public int emp { get; set; }

    public DateTime start_date { get; set; }

    public DateTime end_date { get; set; }

    public string? _event { get; set; }

    public DateTime create_time { get; set; }

    public DateTime? execute_time { get; set; }
}
