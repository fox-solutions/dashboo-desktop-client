using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashbooCalendar.Models
{
    public class DashbooTile
    {
        public int TileId { get; private set; }

        public DateTime Date { get; private set; }

        private string fullDayName;

        public string FullDayName
        {
            get
            {
               return fullDayName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(Date.DayOfWeek);
            }
        }

        private string shortDayName;

        public string ShortDayName
        {
            get
            {
                return shortDayName = CultureInfo.CurrentCulture.DateTimeFormat.GetShortestDayName(Date.DayOfWeek);
            }
        }

        private string monthName;

        public string MonthName
        {
            get
            {
                return monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Date.Month);
            }
        }

        public IEnumerable<DashbooEvent> dashbooEvents { get; private set; }

        private int dashbooEventCounter;
        public int DashbooEventCounter
        {
            get
            {
                return dashbooEventCounter = dashbooEvents.Count();
            }
        }

        public DashbooTile(DateTime date)
        {
            Date = date;
            dashbooEvents = new List<DashbooEvent>();
        }

    }
}
