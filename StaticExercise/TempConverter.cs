using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double temp)
        { 
            var convertedTemp = (temp - 32) * (5.0 / 9.0);
            return convertedTemp;
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            var convertedTemp = (temp * 1.8d) + 32;
            return convertedTemp;
        }

    }


    

}
