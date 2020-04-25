using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace dashboo.Base.Model
{
    public class Tile
    {
		#region Constructor
		public Tile()
		{
			Id = 0;
			Date = new DateTime(0, 0, 0);
			events = new ObservableCollection<Event>();
		}

		public Tile(DateTime date)
		{
			Date = date;
			events = new ObservableCollection<Event>();
		}
		#endregion

		#region Member
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private DateTime _date;

		public DateTime Date
		{
			get { return _date; }
			set { _date = value; }
		}

		private string _fullDayName;

		public string FullDayName
		{
			get { return _fullDayName; }
			set { _fullDayName = getFullDayName(); }
		}

		private string _shortDayName;

		public string ShortDayName
		{
			get { return _shortDayName; }
			set { _shortDayName = getShortDayName(); }
		}

		private string _monthName;

		public string MonthName
		{
			get { return _monthName; }
			set { _monthName = getMonthName(); }
		}

		private int _eventCounter;

		public int EventCounter
		{
			get { return _eventCounter; }
			set { _eventCounter = events.Count; }
		}

		public ICollection<Event> events;
		#endregion

		#region Method
		public string getFullDayName()
		{
			return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(Date.DayOfWeek);
		}

		public string getShortDayName()
		{
			return CultureInfo.CurrentCulture.DateTimeFormat.GetShortestDayName(Date.DayOfWeek);
		}

		public string getMonthName()
		{
			return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Date.Month);
		}
		#endregion
	}
}
