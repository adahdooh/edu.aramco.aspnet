using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_celery_beat_solarschedule
{
    public int id { get; set; }

    public string _event { get; set; } = null!;

    public decimal latitude { get; set; }

    public decimal longitude { get; set; }

    public virtual ICollection<django_celery_beat_periodictask> django_celery_beat_periodictasks { get; set; } = new List<django_celery_beat_periodictask>();
}
