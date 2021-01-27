using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season;

namespace WorldOfBeasts.Strateg
{
    class StrategHare : IStrategAnimalInSeson
    {
        public void Fall()
        {
            Console.WriteLine("Зайцы линяют осенью.");
        }

        public void Spring()
        {
            Console.WriteLine("С приближением зимы, как мы все знаем, заяц меняет серую шубку на белую," +
                 " и ходит в ней в течение снежного, холодного периода, а весной опять «переодевается» в летний буро-сероватый наряд.");

        }

        public void Summer()
        {
            Console.WriteLine("Обычно кормёжка зайцев (жировка) начинается с заходом солнца и заканчивается к рассвету, но " +
              "летом ночного времени не хватает и зайцы кормятся по утрам. Летом в тундре зайцы, спасаясь от гнуса, переходят на дневное питание.");
        }

        public void Winter()
        {
            Console.WriteLine("Зайцы зимой перебираются поближе к человеку зайцы. Удобней им по утоптанным дорогам скакать, " +
                "да и корма в лесах и парках зимой больше, чем в полях. Часто, выходя на лыжную прогулку, можно встретить следы зайцев на снегу.");
        }
    }
}
