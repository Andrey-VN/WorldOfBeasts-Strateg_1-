using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Strateg;

namespace WorldOfBeasts.Beasts
{
    class Hare : Animal
    {
        public Hare()
        {
            strategAnimalInSeson = new StrategHare();

        }
        public override void Name()
        {
            Console.WriteLine("Заяц");
        }

        public override void AnimalClass()
        {
            Console.WriteLine("Млекопитающее");
        }
    }
}
