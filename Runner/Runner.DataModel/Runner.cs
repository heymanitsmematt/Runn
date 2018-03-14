using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runn.DataModel
{
    public class Runner
    {
        public int RunnerId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        public virtual List<Run> Runs { get; set; } 
        public RunnerAccount Account { get; set; }

    }
}
