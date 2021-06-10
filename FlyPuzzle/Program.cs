using System;
using FlyPuzzle.BusinessLogic;


namespace FlyPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane biplane = new Airplane();
            Jet boing = new Jet();

            biplane.SetSpeed(212);
            Console.WriteLine(biplane.GetSpeed());

            boing.SetSpeed(422);
            Console.WriteLine(boing.GetSpeed());

            int x = 0;
            while (x < 4)
            {
                boing.Accelerate();
                Console.WriteLine(boing.GetSpeed());

                if (boing.GetSpeed() > 5000)
                {
                    biplane.SetSpeed(biplane.GetSpeed() * 2);
                } else
                {
                    boing.Accelerate();
                }
                x++;
            }
            Console.WriteLine(biplane.GetSpeed());
        }
    }
}
