using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashbooCalendar.Models
{
    class DashbooCalendar
    {
        public DateTime Today { get; private set; }

        public string[] ShortDayNames { get; set; }

        private string monthName;

        public string MonthName
        {
            get
            {
                return monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Today.Month);
            }
        }

        public IEnumerable<DashbooTile> DashbooTiles { get; private set; }

        private int dashbooTilesCounter;

        public int DashbooTilesCounter
        {
            get
            {
                return dashbooTilesCounter = DashbooTiles.Count();
            }
        }

        public DashbooCalendar()
        {
            Today = DateTime.Now;
            DashbooTiles = new List<DashbooTile>();
            ShortDayNames = new string[7];

            for(int i=0; i<7; i++)
            {
                ShortDayNames[i] = ((DayOfWeek)i).ToString();
            }
        }
    }
}
