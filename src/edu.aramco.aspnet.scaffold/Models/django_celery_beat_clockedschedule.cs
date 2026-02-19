using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_celery_beat_clockedschedule
{
    public int id { get; set; }

    public DateTime clocked_time { get; set; }

    public bool enabled { get; set; }

    public virtual ICollection<django_celery_beat_periodictask> django_celery_beat_periodictasks { get; set; } = new List<django_celery_beat_periodictask>();
}
