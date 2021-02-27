using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_AssignmentTwo_EstevanCordero.Controllers
{
    public class CellPhoneController : ApiController
    {

        [HttpGet]
        [Route("api/CellPhone/Cell/{letters}")]
        public string Cell(string letters) // User enters letters into the url
        {
            // An array to hold users letters.
            List<string> cellPhone = new List<string> { };
            cellPhone.Add(letters); // add into a list


            List<int> numberCell = cellPhone.ConvertAll(int.Parse);
            // Maybe convert the string into ints


            string message = ""; //output string for final results.

            foreach(int number in numberCell ) // A foreach loop to look through the array.
            {
                //Maybe included an if statement here to check on user input. 
            }

            return message;
        }
    }
}
