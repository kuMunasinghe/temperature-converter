using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using temperature_coververter_api.Models;

namespace temperature_coververter_api.Controllers
{

    public class temperatureController : ApiController
    {
        [EnableCors()]
        [HttpGet]
        [Route("{caseValue}/{valueToConvert}")]
        public double ConvertTemperatures(int caseValue, int valueToConvert)
        {
            try
            {
                Temperature temp = new Temperature();
                double convertedValue = 0;

                switch (caseValue)
                {
                    
                    case 1:
                        // case 1 C to F                     
                        convertedValue=temp.ConvertCelciusToFaranheit(valueToConvert);
                        return convertedValue;
                  
                    case 2:
                        // code 2 C to K
                        convertedValue = temp.ConvertCelciusToKelvin(valueToConvert);
                        return convertedValue;

                    case 3:
                        // case 3 F to C
                        convertedValue = temp.ConvertFaranheitToCelcius(valueToConvert);
                        return convertedValue;

                    case 4:
                        // case 4 F to K
                        convertedValue = temp.ConvertFaranheitToKelvin(valueToConvert);
                        return convertedValue;

                    case 5:
                        // case 5 K to C
                        convertedValue = temp.ConvertKelvinToCelcius(valueToConvert);
                        return convertedValue;

                    case 6:
                        // case 6 K to F
                        convertedValue = temp.ConvertKelvinToFaranheit(valueToConvert);
                        return convertedValue;

                    default:
                        // default code block
                        convertedValue = temp.ConvertCelciusToFaranheit(valueToConvert);
                        return convertedValue;

                }

                
            } catch(Exception ex) {
                return Convert.ToDouble(HttpError(500));
            }
        }

        private object HttpError(int v)
        {
            throw new NotImplementedException();
        }
    }
}
