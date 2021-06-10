using System;

namespace FlyPuzzle.BusinessLogic
{
    public class Airplane
    {
        private int _speed;
        
        public virtual void SetSpeed(int speed)
        {
            _speed = speed;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
