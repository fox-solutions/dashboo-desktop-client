using System;
using static System.Net.Mime.MediaTypeNames;

namespace dashboo.Common.Model
{
	public class Event
    {
		#region Constructor
		public Event()
		{
			Id = 0;
			Title = "Event";
			Description = "Description";
			Duration = new DateTime(0, 0, 0);
		}

		public Event(string title, string description)
		{
			Title = title;
			Description = description;
		}

		#endregion

		#region Member
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private DateTime _duration;

		public DateTime Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}
		#endregion
	}
}
