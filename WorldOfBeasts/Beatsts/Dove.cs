using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Fly;

using WorldOfBeasts.Strateg;

namespace WorldOfBeasts.Beasts
{
    class Dove : Animal
    {
        public Dove()
        {
            fly = new YesFly();                          
            strategAnimalInSeson = new StrategDove();  
        }
        public override void Name()
        {
            Console.WriteLine("Голубь");
        }
        public override void AnimalClass()
        {
            Console.WriteLine("Птица");
        }

    }
}
