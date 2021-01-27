using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfBeasts.Season.Winter
{
    class WolfWinter : IWinter
    {
        public void WinterSeson()
        {
            Console.WriteLine("Волки зимой ведут бродячую жизнь, выходя на поиски добычи " +
                "в сумерки и по ночам. Днем они прячутся в заросли кустарников и по оврагам. ");
        }
    }
}
