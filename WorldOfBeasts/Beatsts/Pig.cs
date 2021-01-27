using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season.Fall;
using WorldOfBeasts.Season.Spring;
using WorldOfBeasts.Season.Summer;
using WorldOfBeasts.Season.Winter;

namespace WorldOfBeasts.Beasts
{
    class Pig : Animal
    {
        public Pig()
        {
            fall = new PigFall();
            spring = new PigSpring();
            summer = new PigSummer();
            winter = new PigWinter();
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
