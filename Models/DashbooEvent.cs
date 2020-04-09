using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashbooCalendar.Models
{
    public class DashbooEvent
    {
        public int DashbooEventId { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public DateTime EventDate { get; private set; }

        public DashbooEvent(string title, string description, DateTime eventDate)
        {
            Title = title;
            Description = description;
            EventDate = eventDate;
        }
    }
}
