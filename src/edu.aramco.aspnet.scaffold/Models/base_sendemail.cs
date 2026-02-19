using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class base_sendemail
{
    public int id { get; set; }

    public int purpose { get; set; }

    public string email_to { get; set; } = null!;

    public string? email_cc { get; set; }

    public string? email_bcc { get; set; }

    public string email_subject { get; set; } = null!;

    public string? email_content { get; set; }

    public DateTime? send_time { get; set; }

    public short? send_status { get; set; }
}
