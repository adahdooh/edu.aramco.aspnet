using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class iclock_terminal
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string ip_address { get; set; } = null!;

    public short terminal_tz { get; set; }

    public int heartbeat { get; set; }

    public short transfer_mode { get; set; }

    public int transfer_interval { get; set; }

    public string transfer_time { get; set; } = null!;

    public string? fw_ver { get; set; }

    public string push_protocol { get; set; } = null!;

    public string? push_ver { get; set; }

    public int? language { get; set; }

    public string? terminal_name { get; set; }

    public string? platform { get; set; }

    public string? oem_vendor { get; set; }

    public int? user_count { get; set; }

    public int? transaction_count { get; set; }

    public int? fp_count { get; set; }

    public string? fp_alg_ver { get; set; }

    public int? face_count { get; set; }

    public string? face_alg_ver { get; set; }

    public int? fv_count { get; set; }

    public string? fv_alg_ver { get; set; }

    public int? palm_count { get; set; }

    public string? palm_alg_ver { get; set; }

    public short lock_func { get; set; }

    public string? log_stamp { get; set; }

    public string? op_log_stamp { get; set; }

    public string? capture_stamp { get; set; }

    public string sn { get; set; } = null!;

    public string alias { get; set; } = null!;

    public string? real_ip { get; set; }

    public int state { get; set; }

    public short? product_type { get; set; }

    public short is_attendance { get; set; }

    public short is_registration { get; set; }

    public short? purpose { get; set; }

    public short? controller_type { get; set; }

    public short authentication { get; set; }

    public string? style { get; set; }

    public string? upload_flag { get; set; }

    public bool is_tft { get; set; }

    public DateTime? last_activity { get; set; }

    public DateTime? upload_time { get; set; }

    public DateTime? push_time { get; set; }

    public short is_access { get; set; }

    public int? area_id { get; set; }

    public virtual ICollection<acc_accterminal> acc_accterminals { get; set; } = new List<acc_accterminal>();

    public virtual personnel_area? area { get; set; }

    public virtual ICollection<ep_eptransaction> ep_eptransactions { get; set; } = new List<ep_eptransaction>();

    public virtual ICollection<iclock_errorcommandlog> iclock_errorcommandlogs { get; set; } = new List<iclock_errorcommandlog>();

    public virtual ICollection<iclock_publicmessage> iclock_publicmessages { get; set; } = new List<iclock_publicmessage>();

    public virtual ICollection<iclock_terminalcommandlog> iclock_terminalcommandlogs { get; set; } = new List<iclock_terminalcommandlog>();

    public virtual ICollection<iclock_terminalcommand> iclock_terminalcommands { get; set; } = new List<iclock_terminalcommand>();

    public virtual ICollection<iclock_terminallog> iclock_terminallogs { get; set; } = new List<iclock_terminallog>();

    public virtual ICollection<iclock_terminalparameter> iclock_terminalparameters { get; set; } = new List<iclock_terminalparameter>();

    public virtual ICollection<iclock_terminaluploadlog> iclock_terminaluploadlogs { get; set; } = new List<iclock_terminaluploadlog>();

    public virtual ICollection<iclock_transactionproofcmd> iclock_transactionproofcmds { get; set; } = new List<iclock_transactionproofcmd>();

    public virtual ICollection<iclock_transaction> iclock_transactions { get; set; } = new List<iclock_transaction>();

    public virtual meeting_meetingroomdevice? meeting_meetingroomdevice { get; set; }

    public virtual ICollection<meeting_meetingtransaction> meeting_meetingtransactions { get; set; } = new List<meeting_meetingtransaction>();

    public virtual ICollection<visitor_visitortransaction> visitor_visitortransactions { get; set; } = new List<visitor_visitortransaction>();
}
