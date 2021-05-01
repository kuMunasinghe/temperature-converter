using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace temperature_coververter_api.Models
{
    public class Temperature
    {
   

        public double ConvertCelciusToKelvin(int value)
        {
         
            return value + 273;
        }

        public double ConvertCelciusToFaranheit(int value)
        {
          
            return Convert.ToDouble((value * 9) / 5 + 32);
        }

        public double ConvertFaranheitToCelcius(int value)
        {
        
            return Convert.ToDouble((value - 32) * 5 / 9); 
        }
        public double ConvertFaranheitToKelvin(int value)
        {
            return Convert.ToDouble(273.5 + ((value - 32.0) * (5.0 / 9.0)));
            
        }
        public double ConvertKelvinToCelcius(int value)
        {

            return Convert.ToDouble(value - 273);
        }
        public double ConvertKelvinToFaranheit(int value)
        {

             return Convert.ToDouble(9 / 5 * (value - 273) + 32);
        }
    }
}