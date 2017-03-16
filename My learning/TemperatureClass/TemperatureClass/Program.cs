using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureClass
{

    class Temperature
    {

        private double ftemp;
        public Temperature(double ftemp)
        {
            if (ftemp.ToString().Trim().Length == 0 || ftemp.ToString() == null)
            {
                throw new Exception("Illegal arguments passed");

            }
            this.ftemp = ftemp;
        }
        public double getFahrenheit()
        {
            return ftemp;
        }
        public double getCelsius()
        {
            return ((double)5 / 9 * (ftemp - 32));
        }
        public double getKelvin()
        {
            return (((double)5 / 9 * (ftemp - 32)) + 273);
        }
    }
}
