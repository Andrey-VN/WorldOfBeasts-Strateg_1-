using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Fly;
using WorldOfBeasts.Season;


namespace WorldOfBeasts.Beasts
{       
    /// <summary>
    /// Данная программа отображает поведение животных в зависимости от времени года. В примере используется паттерн "стратегия".
    /// </summary>
    public abstract class Animal
    {
        protected IFly fly;  // интерфейс для алгоритма определения, летает ли данное животное

        protected IStrategAnimalInSeson strategAnimalInSeson;  // интерфейс алгоритма зависимости поведения животных от времени года. ссылка на объект IStrategAnimalInSeson

        public Animal()
        {
            fly = new NoFly();   // инициализация переменной интерфейса IFly с реализацией метода с пустым телом
        }

        /// <summary>
        /// Вызовы методов, описывающих характеристики животного
        /// </summary>
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

        /// <summary>
        /// Абстрактные методы, реализующие постоянные значения для каждого животного (Имя и класс животного не меняется)
        /// </summary>
        public abstract void Name();   
        public abstract void AnimalClass();
    }

}
