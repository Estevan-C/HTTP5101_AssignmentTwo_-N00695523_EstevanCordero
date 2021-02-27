using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_AssignmentTwo_EstevanCordero.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// Determines how many times the value of 10 can appear after given two numbers.
        /// </summary>
        /// <param name="dice1"></param>
        /// <param name="dice2"></param>
        /// <returns>
        /// GET ../api/DiceGame/Dice/6/8
        /// "There are 5 total ways to get the sum of 10."
        /// </returns>
        [Route("api/DiceGame/Dice/{dice1}/{dice2}")]
        [HttpGet]
        public string Dice(int dice1, int dice2)
        {
            int counter = 0; // Var to keep track
            if ((dice1 < 1000) && (dice2 < 1000))
            {// Checks if user enters both number that is less then 1000. 
            
                    for (int diceCount = 0; diceCount <= dice1 && diceCount < 10; diceCount++)
                    { // Loop function that checks between two conditions

                        int totalDice = 10 - diceCount; 
                        // Var that takes the loop increments and subtract by 10
                        if (totalDice <= dice2) 
                        // Checks if the total amount is less then the secound user input.
                        {
                            counter++; 
                        // If condtions met will add +1 to the counter var.
                        }
                }

            }
            // String message to output results.
            string message = "There are " + counter + " total ways to get the sum of 10.";
            return message;
        }

    }
}

