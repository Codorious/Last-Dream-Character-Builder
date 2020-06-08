using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Dream_Character_Builder
{
    class PlayerAttribute
    {
        public int AttValue { get; set; }
        public int AttLevel { get; set; }
        public int InitPointCost { get; }
        public double PointCostInc { get; }
        public int InitPointStatGrowth { get; }
        public double PointStatGrowthInc { get; }

        public PlayerAttribute(int attributeValue, int initialPC, double pointCI, int initialPSG, double pointSGI)
        {
            AttValue = attributeValue;
            AttLevel = 0;
            InitPointCost = initialPC;
            PointCostInc = pointCI;
            InitPointStatGrowth = initialPSG;
            PointStatGrowthInc = pointSGI;
        }
    }
}
