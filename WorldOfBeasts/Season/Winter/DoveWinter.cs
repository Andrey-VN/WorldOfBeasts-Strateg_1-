using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfBeasts.Season.Winter
{
    class DoveWinter : IWinter
    {
        public void WinterSeson()
        {
            Console.WriteLine("В зимний период голуби не улетают в теплые края, а остаются на своем обжитом месте. " +
                "Большинство людей даже не задумываются о том, как живет голубь зимой, где прячется в непогоду и чем питается.");
        }
    }
}
