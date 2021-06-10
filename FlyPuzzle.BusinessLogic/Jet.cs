using System;
using System.Collections.Generic;
using System.Text;

namespace FlyPuzzle.BusinessLogic
{
    public class Jet : Airplane
    {

        public override void SetSpeed(int speed)
        {
            int multiplier = 2;
            base.SetSpeed(speed * multiplier);
        }

        public void Accelerate()
        {
            int multiplier = 2;
            base.SetSpeed(base.GetSpeed() * multiplier);
            
        }


    }
}
