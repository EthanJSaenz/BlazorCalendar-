using System;
using System.Collections.Generic;

namespace Microsoft_API_Calendar.Models
{

    public class CalendarEvent
    {
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public CalendarEvent()
        {
            Subject = string.Empty; // Default to an empty string
        }
    }
}
