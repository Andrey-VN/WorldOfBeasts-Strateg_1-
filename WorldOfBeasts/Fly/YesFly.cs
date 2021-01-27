using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfBeasts.Fly
{
    class YesFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Умеет летать");
        }
    }
}
