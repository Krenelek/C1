using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    abstract class Cell             //prototype of Cells, builder of CarbonDioxide
    {
        protected bool isInfected;
        abstract public void SetIsInfectedByVirus();
        abstract public bool GetIsInfectedByVirus();
        abstract public CarbonDioxide Breathe(Oxygen O, Carbon C);
        
       
    }
}
