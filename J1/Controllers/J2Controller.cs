using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace J1.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/j2/dicegame/{m}/{n}")]
        // GET: api/j2/dicegame/{m}/{n}
        public string DiceGame(int m,int n)
        {
            int counter = 0;
            for(int i = 1; i <= m; i++)
            {
                for(int j=1;j <= n; j++)
                {
                    if((i+j) == 10)
                    {
                        counter = counter + 1;
                    }
                }
            }
            if(counter > 0 && counter < 2)
            {
                return "There is " + counter + " way to get the sum 10";

            }
            else
            {
                return "There are " + counter + " ways to get the sum 10";
            }
        }
    }
}
