using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runn.DataModel
{
    public class RunData
    {
        public int RunDataId { get; set; }
        public Run Run { get; set; }
        public int SplitNum { get; set; }
        public TimeSpan SplitTime { get; set; }
        public int SplitDistance { get; set; }

        public virtual List<MapData> MapData { get; set; } 
    }
}
