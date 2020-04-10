using DashbooCalendar.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashbooCalendar.Model
{
    public class EventManager : IEventManager
    {
        public bool Add(DashbooEvent dashbooEvent, ref ICollection<DashbooEvent> dashbooEvents)
        {
            if (CheckIfTermIsFree(dashbooEvent.EventDate, ref dashbooEvents))
            {
                dashbooEvents.Add(dashbooEvent);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Remove(DashbooEvent dashbooEvent, ref ICollection<DashbooEvent> dashbooEvents)
        {
            if(FindElement(dashbooEvent, ref dashbooEvents) != null)
            {
                dashbooEvents.Remove(dashbooEvent);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Update(DashbooEvent dashbooEvent, ref ICollection<DashbooEvent> dashbooEvents)
        {
            var element = FindElement(dashbooEvent, ref dashbooEvents);

            if (element != null)
            {
                Remove(element, ref dashbooEvents);
                Add(dashbooEvent, ref dashbooEvents);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckIfTermIsFree(DateTime date, ref ICollection<DashbooEvent> dashbooEvents)
        {
            foreach(var dashbooEvent in dashbooEvents)
            {
                if (dashbooEvent.EventDate == date)
                    return false;
            }

            return true;
        }

        public DashbooEvent FindElement(DashbooEvent dashbooEvent, ref ICollection<DashbooEvent> dashbooEvents)
        {
            foreach(var element in dashbooEvents)
            {
                if ((element.Title == dashbooEvent.Title) && (element.EventDate == dashbooEvent.EventDate))
                    return element;
            }

            return null;
        }

    }
}
