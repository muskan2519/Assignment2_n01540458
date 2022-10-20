using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01540458.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// Burger choices - 
        /// 1 - Cheeseburger (461 Calories)
        /// 2 - Fish Burger (431 Calories)
        /// 3 - Veggie Burger (420 Calories)
        /// 4 - no burger
        /// Drink choices - 
        /// 1 - Soft Drink (130 Calories)
        /// 2 - Orange Juice (160 Calories)
        /// 3 - Milk (118 Calories)
        /// 4 - no drink
        /// Side choices - 
        /// 1 - Fries (100 Calories)
        /// 2 - Baked Potato (57 Calories)
        /// 3 - Chef Salad (70 Calories)
        /// 4 - no side order
        /// Dessert choices - 
        /// 1 - Apple Pie (167 Calories)
        /// 2 - Sundae (266 Calories)
        /// 3 - Fruit Cup (75 Calories)
        /// 4 - No Dessert
        /// returns => a string displaying total calorie count
        /// </summary>
        /// <param name="burger">index of choice of burger</param>
        /// <param name="drink">index of choice of drink</param>
        /// <param name="side">index of choice of side</param>
        /// <param name="dessert">index of choice of dessert</param>
        /// <returns>
        /// Your total calorie count is {total calories}
        /// </returns>
        /// GET /api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        /// <example>
        /// /api/J1/Menu/4/4/4/4
        /// <returns>
        /// Your total calorie count is 0.
        /// </returns>
        /// </example>
        /// <example>
        /// /api/J1/Menu/1/2/3/4
        /// <returns>
        /// Your total calorie count is 691.
        /// </returns>
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetOrderDetails(int burger, int drink, int side, int dessert)
        {
            int burgerCal = 0;
            int drinkCal = 0;
            int sideCal = 0;
            int dessertCal = 0;
            int totalCal = 0;
            switch(burger)
            {
                case 1: 
                    burgerCal = 461;
                    break;
                case 2:
                    burgerCal = 431;
                    break;
                case 3:
                    burgerCal = 420;
                    break;
                case 4:
                    burgerCal = 0;
                    break;
                default:
                    burgerCal = 0;
                    break;
            }
            switch (drink)
            {
                case 1:
                    drinkCal = 130;
                    break;
                case 2:
                    drinkCal = 160;
                    break;
                case 3:
                    drinkCal = 118;
                    break;
                case 4:
                    drinkCal = 0;
                    break;
                default:
                    drinkCal = 0;
                    break;
            }
            switch (side)
            {
                case 1:
                    sideCal = 100;
                    break;
                case 2:
                    sideCal = 57;
                    break;
                case 3:
                    sideCal = 70;
                    break;
                case 4:
                    sideCal = 0;
                    break;
                default:
                    sideCal = 0;
                    break;
            }
            switch (dessert)
            {
                case 1:
                    dessertCal = 167;
                    break;
                case 2:
                    dessertCal = 266;
                    break;
                case 3:
                    dessertCal = 75;
                    break;
                case 4:
                    dessertCal = 0;
                    break;
                default:
                    dessertCal = 0;
                    break;
            }
            totalCal = burgerCal + drinkCal + sideCal + dessertCal;
            return "Your total calorie count is " + totalCal;
        }
    }
}
