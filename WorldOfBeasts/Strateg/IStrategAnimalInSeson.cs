using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfBeasts.Season
{
    public interface IStrategAnimalInSeson
    {
        /// <summary>
        /// Общий интерфейс для всех реализующих алгоритмов зависимости конкретного животного от конкретного времени года
        /// </summary>
        public void Fall();
        public void Spring();
        public void Summer();
        public void Winter();


    }
}
