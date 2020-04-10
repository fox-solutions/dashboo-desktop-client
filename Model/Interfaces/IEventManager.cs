using DashbooCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashbooCalendar.Model
{
    public interface IEventManager : IBaseManager<DashbooEvent>
    {
        bool CheckIfTermIsFree(DateTime date, ref ICollection<DashbooEvent> dashbooEvents);
        DashbooEvent FindElement(DashbooEvent dashbooEvent, ref ICollection<DashbooEvent> dashbooEvents);
    }
}
