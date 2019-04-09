using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class CarbonDioxide
    {
        public CarbonDioxide(Oxygen _O, Carbon _C)
        {
            _O.amountOfAtoms=-2;
            _C.amountOfAtoms--;
        }
    }
}
