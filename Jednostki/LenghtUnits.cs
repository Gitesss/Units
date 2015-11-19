using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jednostki
{
    class LenghtUnits : Units
    {

        public LenghtUnits()
        {
            MakeUnits();
            unit = "metr";
        }

        public override void MakeUnits()
        {  
            base.MakeUnits();
            preUnits.Add(new PreUnits("", 1));
            preUnits.Add(new PreUnits("decy",10));
        }
    }
}
