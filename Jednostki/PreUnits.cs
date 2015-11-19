using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jednostki
{
    class PreUnits
    {
       public string name{set;get; }
       public double value{set;get; }

        public PreUnits(string name_, double value_)
        {
            name = name_;
            value = value_;
        }
    }
    
}
