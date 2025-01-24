using System;
using System.Collections.Generic;

namespace Microsoft_API_Calendar.Models
{


    public class CalendarEvent
    {
        public required string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
