using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class audit
{
    public long Id { get; set; }

    public long TransactionId { get; set; }

    public string EventType { get; set; } = null!;

    public DateTime? OldValue { get; set; }

    public DateTime PunchTime { get; set; }

    public string EmpCode { get; set; } = null!;

    public string? UpdatedByEmail { get; set; }

    public DateTime CreatedOn { get; set; }
}
