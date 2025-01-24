using System;
using System.Collections.Generic;

namespace BlazorCalendar.Models
{


    public class CalendarEvent
    {
        public string Subject{get; set;}
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
    }
}
