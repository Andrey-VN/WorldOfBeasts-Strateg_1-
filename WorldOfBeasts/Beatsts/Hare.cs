using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season.Fall;
using WorldOfBeasts.Season.Spring;
using WorldOfBeasts.Season.Summer;
using WorldOfBeasts.Season.Winter;

namespace WorldOfBeasts.Beasts
{
    class Hare : Animal
    {
        public Hare()
        {
            fall = new HareFall();
            spring = new HareSpring();
            summer = new HareSummer();
            winter = new HareWinter();
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
