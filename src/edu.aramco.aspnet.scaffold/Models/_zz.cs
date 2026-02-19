using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class _zz
{
    public int id { get; set; }

    public string emp_code { get; set; } = null!;

    public DateTime punch_time { get; set; }

    public string punch_state { get; set; } = null!;

    public int verify_type { get; set; }

    public string? work_code { get; set; }

    public string? terminal_sn { get; set; }

    public string? terminal_alias { get; set; }

    public string? area_alias { get; set; }

    public double? longitude { get; set; }

    public double? latitude { get; set; }

    public string? gps_location { get; set; }

    public string? mobile { get; set; }

    public short? source { get; set; }

    public short? purpose { get; set; }

    public string? crc { get; set; }

    public short? is_attendance { get; set; }

    public string? reserved { get; set; }

    public DateTime? upload_time { get; set; }

    public short? sync_status { get; set; }

    public DateTime? sync_time { get; set; }

    public short? is_mask { get; set; }

    public decimal? temperature { get; set; }

    public int? emp_id { get; set; }

    public int? terminal_id { get; set; }

    public string? company_code { get; set; }

    public string? new_property { get; set; }
}
