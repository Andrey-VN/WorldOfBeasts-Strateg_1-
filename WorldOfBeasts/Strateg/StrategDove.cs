using System;
using System.Collections.Generic;
using System.Text;
using WorldOfBeasts.Season;

namespace WorldOfBeasts.Strateg
{
    public class StrategDove : IStrategAnimalInSeson
    {
        /// <summary>
        /// реализация методов интерфейса IStrategAnimalInSeson
        /// </summary>
        public void Fall()
        {
            Console.WriteLine("Линька у взрослых голубей обычно проходит осенью, а у молодняка после того, как он начинает летать.");
        }

        public void Spring()
        {
            Console.WriteLine("В весенний период голуби строят гнезда.");
        }


        public void Summer()
        {
            Console.WriteLine("Летом голуби гуляют и греются на солнышке.");
        }

        public void Winter()
        {
            Console.WriteLine("В зимний период голуби не улетают в теплые края, а остаются на своем обжитом месте. " +
               "Большинство людей даже не задумываются о том, как живет голубь зимой, где прячется в непогоду и чем питается.");
        }
    }
}
