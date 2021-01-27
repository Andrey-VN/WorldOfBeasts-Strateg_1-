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
    public abstract class Animal
    {
        protected IFly fly;
        protected IFall fall;
        protected ISpring spring;
        protected ISummer summer;
        protected IWinter winter;

        public Animal()
        {
            fly = new NoFly();
            fall = new NoInfoFall();
            spring = new NoInfoSpring();
            summer = new NoInfoSummer();
            winter = new NoInfoWinter();
        }
        public void Fly()
        {
            fly.Fly();
        }
        public void Spring()
        {
            spring.SpringSeson();
        }
        public void Summer()
        {
            summer.SummerSeson();
        }
        public void Winter()
        {
            winter.WinterSeson();
        }
        public void Fall()
        {
            fall.FallSeson();
        }


        public abstract void Name();
        public abstract void AnimalClass();
    }

}
