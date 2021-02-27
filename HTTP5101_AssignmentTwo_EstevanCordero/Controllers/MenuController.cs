using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_AssignmentTwo_EstevanCordero.Controllers
{
    public class MenuController : ApiController
    {

        /// <summary>
        /// Outputs the total Calorie Count 
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <returns>
        /// GET ../api/Menu/Order/1/2/3/4
        /// "Your total calorie count is 691."
        /// </returns>

        [Route("api/Menu/Order/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Order(int burger, int drink, int side, int dessert)
        {
            // Empty Variables to updated or set for 0 amount.
            int calories = 0;
            int noOrder = 0;
          
            // Variables for Burgers and amounts.
            int cheeseB = 461;
            int fishB = 431;
            int veggieB = 420;
           
            // Variables for Drinks and amounts.
            int softD = 130;
            int orangeJ = 160;
            int milk = 118;
            
            // Variables for Sides and amounts.
            int fries = 100;
            int bakedP = 57;
            int chefS = 70;

            // Variables for Desserts and amounts.
            int appleP = 167;
            int sundae = 266;
            int fruitC = 75;

            //If Else Statements that checks if the user enters a number between 1-4. 
            // Adds amount into var calories based on what the user enter. 
            if (burger == 1) calories = cheeseB + calories;
            else if (burger == 2) calories = fishB + calories;
            else if (burger == 3) calories = veggieB + calories;
            else if (burger == 4) calories = noOrder + calories;

            if (drink == 1) calories = softD + calories;
            else if (drink == 2) calories = orangeJ + calories;
            else if (drink == 3) calories = milk + calories;
            else if (drink == 4) calories = noOrder + calories;

            if (side == 1) calories = fries + calories;
            else if (side == 2) calories = bakedP + calories;
            else if (side == 3) calories = chefS + calories;
            else if (side == 4) calories = noOrder + calories;

            if (dessert == 1) calories = appleP + calories;
            else if (dessert == 2) calories = sundae + calories;
            else if (dessert == 3) calories = fruitC + calories;
            else if (dessert == 4) calories = noOrder + calories;

            // string message to output results.
            string total = "Your total calorie count is: " + calories + ".";
            return total;
        }


    }
}
