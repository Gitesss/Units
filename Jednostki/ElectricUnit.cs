using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jednostki
{
    class ElectricUnit : Units
    {
        public ElectricUnit()
        {
            MakeUnits();
            unit = "kulomb";
        }

        public override void MakeUnits()
        {
            
            base.MakeUnits();
            preUnits.Add(new PreUnits("", 1));
            preUnits.Add(new PreUnits("mega", 10000000000000));
        }
    }
}
