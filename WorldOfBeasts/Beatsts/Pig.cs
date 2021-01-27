using System;
using System.Collections.Generic;
using System.Text;

using WorldOfBeasts.Strateg;

namespace WorldOfBeasts.Beasts
{
    class Pig : Animal
    {
        public Pig()
        {
            strategAnimalInSeson = new StrategPig();

        }
        public override void Name()
        {
            Console.WriteLine("Свинья");
        }
        public override void AnimalClass()
        {
            Console.WriteLine("Млекопитающее");
        }
    }
}
