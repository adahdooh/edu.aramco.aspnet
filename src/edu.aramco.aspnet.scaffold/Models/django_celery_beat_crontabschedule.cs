using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_celery_beat_crontabschedule
{
    public int id { get; set; }

    public string minute { get; set; } = null!;

    public string hour { get; set; } = null!;

    public string day_of_week { get; set; } = null!;

    public string day_of_month { get; set; } = null!;

    public string month_of_year { get; set; } = null!;

    public string timezone { get; set; } = null!;

    public virtual ICollection<django_celery_beat_periodictask> django_celery_beat_periodictasks { get; set; } = new List<django_celery_beat_periodictask>();
}
