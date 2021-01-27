using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfBeasts.Season
{
    class StrategWolf : IStrategAnimalInSeson
    {
        public void Fall()
        {
            Console.WriteLine("Волки осенью живут семьей.");
        }

        public void Spring()
        {
            Console.WriteLine("Весной волки находят себе пару чаще обычного.");
        }

        public void Summer()
        {
            Console.WriteLine("Во время кочевок, а также летом" +
              " при хорошей погоде не обремененный семьей зверь вообще обходится без убежищ, отдыхает там, где его застанет рассвет или усталость. ");
        }

        public void Winter()
        {
            Console.WriteLine("Волки зимой ведут бродячую жизнь, выходя на поиски добычи " +
              "в сумерки и по ночам. Днем они прячутся в заросли кустарников и по оврагам. ");
        }
    }
}
