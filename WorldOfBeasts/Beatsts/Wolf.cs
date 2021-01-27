using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season.Fall;
using WorldOfBeasts.Season.Spring;
using WorldOfBeasts.Season.Summer;
using WorldOfBeasts.Season.Winter;

namespace WorldOfBeasts.Beasts
{
    class Wolf : Animal
    {
        public Wolf()
        {
            fall = new WolfFall();
            spring = new WolfSpring();
            summer = new WolfSummer();
            winter = new WolfWinter();
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
