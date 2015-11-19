using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jednostki
{
    abstract class Units
    {
        public List<PreUnits> preUnits { set; get; }
        public string unit { set; get; }

        public virtual void MakeUnits()
        {
            preUnits = new List<PreUnits>();
            preUnits.Add(new PreUnits("nano",0.000000001));
            preUnits.Add(new PreUnits("mikro", 0.000001));
            preUnits.Add(new PreUnits("mili", 0.0001));
            preUnits.Add(new PreUnits("kilo", 1000));
        }


    }
}
