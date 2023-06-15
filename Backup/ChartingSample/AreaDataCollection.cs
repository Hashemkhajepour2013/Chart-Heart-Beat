using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartingSample
{
    class AreaDataCollection: System.Collections.ObjectModel.Collection<AreaData>
    {
        public AreaDataCollection()
        {
            Add(new AreaData { Date = new DateTime(2008, 8, 4), Price = 25.25, Volume = 30 });
            Add(new AreaData { Date = new DateTime(2008, 8, 5), Price = 26.25, Volume = 70 });
            Add(new AreaData { Date = new DateTime(2008, 8, 6), Price = 27, Volume = 90 });
            Add(new AreaData { Date = new DateTime(2008, 8, 7), Price = 27.5, Volume = 20 });
            Add(new AreaData { Date = new DateTime(2008, 8, 8), Price = 28.25, Volume = 60 });
        }
    }
}
