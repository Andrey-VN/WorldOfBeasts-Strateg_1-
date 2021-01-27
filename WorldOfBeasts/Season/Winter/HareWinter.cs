using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season.Fall;

namespace WorldOfBeasts.Season.Winter
{
    class HareWinter : IWinter
    {
        public void WinterSeson()
        {
            Console.WriteLine("Зайцы зимой перебираются поближе к человеку зайцы. Удобней им по утоптанным дорогам скакать, " +
                "да и корма в лесах и парках зимой больше, чем в полях. Часто, выходя на лыжную прогулку, можно встретить следы зайцев на снегу.");
        }
    }
}
