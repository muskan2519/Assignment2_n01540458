using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01540458.Controllers
{
    /// <summary>
    /// Question taken from 2011 exam - J3: Sumac Sequence
    /// In a sumac sequence, t1, t2, .., tm, each term is an integer greater than or equal 0. 
    /// Also, each term, starting with the third, is the difference of the preceding two terms
    /// (that is, tn+2 = tn − tn+1 for n ≥ 1). The sequence terminates at tm if tm−1 < tm.
    /// returns => a number displaying length of the sumac sequence
    /// </summary>
    /// <param name="a">first positive integer, which is, 0 < a < 10000</param>
    /// <param name="b">second positive integer, which is, 0 < b < a < 10000</param>
    /// <returns>
    /// {length of the sequence}
    /// </returns>
    /// GET /api/J3/SumacSequence/{a}/{b}
    /// <example>
    /// /api/J3/SumacSequence/120/71
    /// <returns>
    /// 5
    /// </returns>
    /// </example>
    /// <example>
    /// /api/J2/DiceGame/10/7
    /// <returns>
    /// 4
    /// </returns>
    /// </example>
    public class SumacSequenceController : ApiController
    {
        [HttpGet]
        [Route("api/J3/SumacSequence/{a}/{b}")]
        public int GetLength(int a, int b)
        {
            int initialLength = 2; 
            int firstNo = a;
            int secondNo = b;
            if(a>b && a<10000 && b<10000 && a>0 && b>0)
            {
                while(secondNo < firstNo)
                {
                    int newNo = firstNo - secondNo;
                    firstNo = secondNo;
                    secondNo = newNo;
                    initialLength++;
                }
            }
            else
            {
                initialLength = 0;
            }
            return initialLength;
        }
    }
}
