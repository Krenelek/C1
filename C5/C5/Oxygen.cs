using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class Oxygen:Element //fabryka CarbonDioxide i singleton
    {
        private static Oxygen o;
        public static Oxygen GetElement()
        {
            if(o==null)
            {
                o = new Oxygen();
            }
            return o;
        }       
        private Oxygen()
        {
        }
        public CarbonDioxide SustainLife(Carbon C)
        {
            return new CarbonDioxide(this,C);
        }
    }
}
