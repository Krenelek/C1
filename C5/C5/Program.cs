using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            Oxygen oxs = Oxygen.GetElement();
            Carbon c = new Carbon();
            CarbonDioxide co2= oxs.SustainLife(c);//fabryka ew builder, bo zmniejsza ilość węgla
            HumanCell h1 = new HumanCell();//klon
            HumanCell h2 = h1.Divide();
        }
    }
}
