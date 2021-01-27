using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Fly;
using WorldOfBeasts.Season.Fall;
using WorldOfBeasts.Season.Spring;
using WorldOfBeasts.Season.Summer;
using WorldOfBeasts.Season.Winter;

namespace WorldOfBeasts.Beasts
{
    class Dove : Animal
    {
        public Dove()
        {
            fly = new YesFly();
            fall = new DoveFall();
            spring = new DoveSpring();
            summer = new DoveSummer();
            winter = new DoveWinter();

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
