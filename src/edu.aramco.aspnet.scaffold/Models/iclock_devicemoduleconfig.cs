using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_devicemoduleconfig
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public bool enable_registration { get; set; }

    public bool enable_resigned_filter { get; set; }

    public bool enable_auto_add { get; set; }

    public bool enable_name_upload { get; set; }

    public bool enable_name_download { get; set; }

    public bool enable_card_upload { get; set; }

    public bool encryption { get; set; }

    public short timezone { get; set; }

    public bool global_setup { get; set; }

    public int heartbeat { get; set; }

    public short transfer_mode { get; set; }

    public int transfer_interval { get; set; }

    public string transfer_time { get; set; } = null!;

    public short sync_mode { get; set; }

    public string sync_time { get; set; } = null!;

    public int transaction_retention { get; set; }

    public int command_retention { get; set; }

    public int dev_log_retention { get; set; }

    public int upload_log_retention { get; set; }

    public short edit_policy { get; set; }

    public short import_policy { get; set; }

    public short mobile_policy { get; set; }

    public short device_policy { get; set; }

    public short api_policy { get; set; }

    public short visitor_policy { get; set; }
}
