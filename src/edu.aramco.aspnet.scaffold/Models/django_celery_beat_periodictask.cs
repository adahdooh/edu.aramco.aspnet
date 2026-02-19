using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class django_celery_beat_periodictask
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string task { get; set; } = null!;

    public string args { get; set; } = null!;

    public string kwargs { get; set; } = null!;

    public string? queue { get; set; }

    public string? exchange { get; set; }

    public string? routing_key { get; set; }

    public DateTime? expires { get; set; }

    public bool enabled { get; set; }

    public DateTime? last_run_at { get; set; }

    public int total_run_count { get; set; }

    public DateTime date_changed { get; set; }

    public string description { get; set; } = null!;

    public int? crontab_id { get; set; }

    public int? interval_id { get; set; }

    public int? solar_id { get; set; }

    public bool one_off { get; set; }

    public DateTime? start_time { get; set; }

    public int? priority { get; set; }

    public string headers { get; set; } = null!;

    public int? clocked_id { get; set; }

    public virtual django_celery_beat_clockedschedule? clocked { get; set; }

    public virtual django_celery_beat_crontabschedule? crontab { get; set; }

    public virtual django_celery_beat_intervalschedule? interval { get; set; }

    public virtual django_celery_beat_solarschedule? solar { get; set; }
}
