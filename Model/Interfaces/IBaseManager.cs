using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashbooCalendar.Models
{
    public interface IBaseManager<T>
    {
        bool Add(T t, ref ICollection<T> TCollection);
        bool Remove(T t, ref ICollection<T> TCollection);
        bool Update(T t, ref ICollection<T> TCollection);
    }
}
