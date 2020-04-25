using dashboo.Common.Model;
using System;
using System.Collections.ObjectModel;

namespace dashboo.Calendar.ViewModel
{
    class CalendarViewModel
    {
        public ObservableCollection<Tile> Tiles = new ObservableCollection<Tile>()
        {
            new Tile(DateTime.Now)
        };

        public CalendarViewModel()
        {

        }
    }
}
