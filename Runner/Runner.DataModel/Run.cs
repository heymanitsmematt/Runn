using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runn.DataModel
{
    public class Run
    {
        public int RunId { get; set; }
        public Runner Runner { get; set; }
        public DateTime RunStartTime { get; set; }
        public DateTime RunEndTime { get; set; }
        public TimeSpan RunDuration { get; set; }
        public int Pace { get; set; }
        public int Distance { get; set; }

        public virtual List<RunData> RunData { get; set; } 
    }
}
