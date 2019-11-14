using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAssign1
{
    public class Item
    {
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public enum UnitofMeasure
        {
            EACH    = 0,
            BOX     = 1,
            GALLON  = 2,
            POUND   = 3
        }
        public int Weight { get; set; }
    }
}
