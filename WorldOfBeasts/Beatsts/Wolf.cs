using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season;


namespace WorldOfBeasts.Beasts
{
    class Wolf : Animal
    {
        public Wolf()
        {
            strategAnimalInSeson = new StrategWolf();

        }
        public override void Name()
        {
            Console.WriteLine("Волк");
        }
        public override void AnimalClass()
        {
            Console.WriteLine("Млекопитающее");
        }
    }
}
