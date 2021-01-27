using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfBeasts.Season.Winter
{
    class PigWinter : IWinter
    {
        public void WinterSeson()
        {
            Console.WriteLine("Свинка в зимнее время, в теплую погоду, питается побегами растений, " +
                "в холода раздирает корешки деревьев и кустарников (сосны, ясеня, черники, осины). ");
        }
    }
}
