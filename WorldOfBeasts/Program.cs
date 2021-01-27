using System;
using System.Collections.Generic;
using WorldOfBeasts.Beasts;

namespace WorldOfBeasts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();  // создаю коллекцию из Animal

            ///<summary>
            /// добавление экземпляров коллекции Animal
            ///</summary>

            animal.Add(new Wolf());
            animal.Add(new Hare());
            animal.Add(new Dove());
            animal.Add(new Pig());

            foreach (var an in animal)   //извлекаем элементы коллекции в переменную an
            {
                if(an is Wolf)           //Проверяем совместимости объектов для удобного отображения элементов в консоли
                {
                    Console.ForegroundColor = ConsoleColor.Green;    //меняем цвет отображения строк в консоли
                    an.Name();
                    an.AnimalClass();
                    an.Fly();
                    an.Fall();
                    an.Spring();
                    an.Summer();
                    an.Winter();
                }

                if (an is Hare)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    an.Name();
                    an.AnimalClass();
                    an.Fly();
                    an.Fall();
                    an.Spring();
                    an.Summer();
                    an.Winter();
                }

                if (an is Dove)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    an.Name();
                    an.AnimalClass();
                    an.Fly();
                    an.Fall();
                    an.Spring();
                    an.Summer();
                    an.Winter();
                }

                if (an is Pig)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    an.Name();
                    an.AnimalClass();
                    an.Fly();
                    an.Fall();
                    an.Spring();
                    an.Summer();
                    an.Winter();
                }
                Console.WriteLine();
            }

            
            Console.Read();   // задержка
        }
    }
}
