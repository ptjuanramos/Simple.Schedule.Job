using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.Schedule.Job.Models
{
    public enum ScheduleJobType
    {
        Always,
        Daily,
        Minutely,
        Hourly,
        Weekly,
        Monthly
    }
}
