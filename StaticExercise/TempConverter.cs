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
            var convertedTemp = (temp - 30) / 2;
            return convertedTemp;
        }

        public static double CelciusToFahrenheit(double temp)
        {
            var convertedTemp = (temp * 1.8) + 32;
            return convertedTemp;
        }

    }


    

}
