using System;
using System.Collections.Generic;
using WorldOfBeasts.Beasts;

namespace WorldOfBeasts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();

            animal.Add(new Wolf());
            animal.Add(new Hare());
            animal.Add(new Dove());
            animal.Add(new Pig());

            foreach (var an in animal)
            {
                if(an is Wolf)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
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

            
            Console.Read();
        }
    }
}
