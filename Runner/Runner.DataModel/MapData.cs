using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runn.DataModel
{
    public class MapData
    {
        public int MapDataId { get; set; }
        public Run Run { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int Sequence { get; set; }
    }
}
