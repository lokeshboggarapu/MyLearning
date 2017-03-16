using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fever_alaram
{
    class Program
    {
        static void Main(string[] args)
        {

            Temperature temperature = new Temperature(98.2, Temperature.SCALE.CELCIUS, Temperature.RECOREDTYPE.ARMPITS,Temperature.RECORDEDDURING.AFTERNOON, System.DateTime.Now);
            Console.WriteLine(temperature.isHavingFever(temperature));
            Console.ReadKey();
	
        }
    }
}
