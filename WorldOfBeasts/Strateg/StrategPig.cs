using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season;

namespace WorldOfBeasts.Strateg
{
    class StrategPig : IStrategAnimalInSeson
    {
        public void Fall()
        {
            Console.WriteLine("Осенью свинка идет в школу.");
        }

        public void Spring()
        {
            Console.WriteLine("Свинка в весеннее время: \"Существует\"");
        }

        public void Summer()
        {
            Console.WriteLine("Летом свинке жарко и она часто купается.");
        }

        public void Winter()
        {
            Console.WriteLine("Свинка в зимнее время, в теплую погоду, питается побегами растений, " +
                 "в холода раздирает корешки деревьев и кустарников (сосны, ясеня, черники, осины). ");
        }
    }
}
