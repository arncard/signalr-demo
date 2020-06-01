using System;
using System.Collections.Generic;

namespace RealTimeCalendar_Server.Models
{
    public class SchedulerEvent
    {
        public int id { get; set; }
        public DateTime start { get; set; }
        public string startTimezone { get; set; }
        public DateTime end { get; set; }
        public string endTimezone { get; set; }
        public bool isAllDay { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string recurrenceRule { get; set; }
        public int recurrenceId { get; set; }
        public List<DateTime> recurrenceExceptions { get; set; }
        public SchedulerEvent()
        {
            recurrenceExceptions = new List<DateTime>();
        }
    }
}