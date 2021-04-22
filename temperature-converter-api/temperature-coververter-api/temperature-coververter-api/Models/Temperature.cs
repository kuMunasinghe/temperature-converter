using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace temperature_coververter_api.Models
{
    public class Temperature
    {
   

        public int ConvertCelciusToKelvin(int value)
        {
         
            return value + 273;
        }

        public int ConvertCelciusToFaranheit(int value)
        {
          
            return (value * 9) / 5 + 32;
        }

        public int ConvertFaranheitToCelcius(int value)
        {
        
            return (value - 32) * 5 / 9; 
        }
        public double ConvertFaranheitToKelvin(int value)
        {
            return 273.5 + ((value - 32.0) * (5.0 / 9.0));
            
        }
        public double ConvertKelvinToCelcius(int value)
        {

            return value - 273;
        }
        public double ConvertKelvinToFaranheit(int value)
        {

             return 9 / 5 * (value - 273) + 32;
        }
    }
}