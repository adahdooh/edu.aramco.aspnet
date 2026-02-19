using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_celery_beat_intervalschedule
{
    public int id { get; set; }

    public int every { get; set; }

    public string period { get; set; } = null!;

    public virtual ICollection<django_celery_beat_periodictask> django_celery_beat_periodictasks { get; set; } = new List<django_celery_beat_periodictask>();
}
