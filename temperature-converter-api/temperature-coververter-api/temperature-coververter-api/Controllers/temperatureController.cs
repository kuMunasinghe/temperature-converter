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
        // GET api/values
        public IActionResult ConvertTemperatures(int caseValue, int valueToConvert)
        {
            try
            {
                Temperature temp = new Temperature();


                switch (caseValue)
                {
                    case 1:
                        // case 1 C to F                     
                        return (IActionResult)Ok(temp.ConvertCelciusToFaranheit(valueToConvert));
                        break;
                    case 2:
                        // code 2 C to K
                        return (IActionResult)Ok(temp.ConvertCelciusToKelvin(valueToConvert));
                        break;

                    case 3:
                        // case 3 F to C
                        return (IActionResult)Ok(temp.ConvertFaranheitToCelcius(valueToConvert));
                        break;
                    case 4:
                        // case 4 F to K
                        return (IActionResult)Ok(temp.ConvertFaranheitToKelvin(valueToConvert));
                        break;
                    case 5:
                        // case 5 K to C
                        return (IActionResult)Ok(temp.ConvertKelvinToCelcius(valueToConvert));
                        break;
                    case 6:
                        // case 6 K to F
                        return (IActionResult)Ok(temp.ConvertKelvinToFaranheit(valueToConvert));
                        break;

                    default:
                        // code block
                        return (IActionResult)Ok(temp.ConvertCelciusToFaranheit(valueToConvert));
                        break;
                }

                
            } catch(Exception ex) {
                return HttpError(500);  
            }
        }

        private IActionResult HttpError(int v)
        {
            throw new NotImplementedException();
        }



        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
