using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season.Fall;

namespace WorldOfBeasts.Season.Summer
{
    class HareSummer : ISummer
    {
        public void SummerSeson()
        {
            Console.WriteLine("Обычно кормёжка зайцев (жировка) начинается с заходом солнца и заканчивается к рассвету, но " +
                "летом ночного времени не хватает и зайцы кормятся по утрам. Летом в тундре зайцы, спасаясь от гнуса, переходят на дневное питание.");
        }
    }
}
