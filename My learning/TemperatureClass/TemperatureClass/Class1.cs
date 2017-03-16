using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureClass;

namespace TemperatureClass
{
    class mains

    {
         static void main(String[] args)
        {

            Console.WriteLine("Enter Fahrenheit temperature: ");
            string sc = Console.ReadLine();
            double ftemp = Convert.ToDouble(sc);

            Temperature temp = new Temperature(ftemp);
            Console.WriteLine("The temperature in Fahrenheit is " + temp.getFahrenheit());
            Console.WriteLine("The temperature in Celsius is " + temp.getCelsius());
            Console.WriteLine("The temperature in Kelvin is " + temp.getKelvin());
        }
    }
}
