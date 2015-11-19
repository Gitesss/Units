using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jednostki
{
    class VoltageUnit : Units
    {

        public VoltageUnit()
        {
            MakeUnits();
            unit = "volt";
        }


        public override void MakeUnits()
        {
            base.MakeUnits();
            preUnits.Add(new PreUnits("volt", 1));
            preUnits.Add(new PreUnits("piko", 0.000000000001));
        }
    }
}
