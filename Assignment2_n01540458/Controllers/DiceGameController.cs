using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01540458.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// returns => a string displaying total number of ways so that two dices roll the value of 10
        /// </summary>
        /// <param name="m">Total number of sides on first die</param>
        /// <param name="n">Total number of sides on second die</param>
        /// <returns>
        /// There are {total number of ways} total ways to get the sum 10
        /// </returns>
        /// GET /api/J2/DiceGame/{m}/{n}
        /// <example>
        /// /api/J2/DiceGame/6/8
        /// <returns>
        /// There are 5 total ways to get the sum 10
        /// </returns>
        /// </example>
        /// <example>
        /// /api/J2/DiceGame/12/4
        /// <returns>
        /// There are 4 total ways to get the sum 10
        /// </returns>
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetSides(int m, int n)
        {
            int totalWays = 0;
            for (int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i+j == 10)
                    {
                        totalWays++;
                    }
                }
            }
            return "There are " + totalWays + " total ways to get the sum 10.";
        }
    }
}
