using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Fly;
using WorldOfBeasts.Season;


namespace WorldOfBeasts.Beasts
{
    public abstract class Animal
    {
        protected IFly fly;

        protected IStrategAnimalInSeson strategAnimalInSeson;

        public Animal()
        {
            fly = new NoFly();
        }
        public void Fly()
        {
            fly.Fly();
        }
        public void Spring()
        {
            strategAnimalInSeson.Spring();
        }
        public void Summer()
        {
            strategAnimalInSeson.Summer();
        }
        public void Winter()
        {
            strategAnimalInSeson.Winter();
        }
        public void Fall()
        {
            strategAnimalInSeson.Fall();
        }


        public abstract void Name();
        public abstract void AnimalClass();
    }

}
