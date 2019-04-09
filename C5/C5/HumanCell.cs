using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class HumanCell:Cell //prototyp
    {
        public HumanCell()
        {

        }
        public HumanCell(bool _isInfected)
        {
            isInfected = _isInfected;
        }
        public HumanCell Divide()
        {
            return new HumanCell(isInfected);
        }
        public override CarbonDioxide Breathe(Oxygen O, Carbon C)
        {
            return O.SustainLife(C);
        }
        public override void SetIsInfectedByVirus()
        {
            isInfected = true;
        }
        public override bool GetIsInfectedByVirus()
        {
            return isInfected;
        }    

    }
}
