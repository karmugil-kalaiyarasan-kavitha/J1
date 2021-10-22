using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace J1.Controllers
{

    public class j3Controller : ApiController
    {
        [HttpGet]
        [Route("api/j3/direction/{m}")]
        // GET: api/j3/direction/{m}
        public string[] direction(string m)
        {
            string[] wordArray = m.Split(',');
            int indexValue = wordArray.Length;
            int[] numberArray= new int[indexValue];
            int[] quotientArray = new int[indexValue];
            int[] remainderArray = new int[indexValue];
            int[] twoDigitTotal = new int[indexValue];
            string[] directionArray = new string[indexValue];
            string[] resultArray = new string[indexValue];
            for (int i = 0; i < wordArray.Length; i++)
            {
                numberArray[i] = int.Parse(wordArray[i]);
                quotientArray[i] = (numberArray[i]) / 1000;
                remainderArray[i] = (numberArray[i]) % 1000;

            }

            for(int j = 0; j < quotientArray.Length; j++)
            {
                int sum = 0;
                int n = quotientArray[j];
                int temp;
                while (n > 0)
                {
                    temp = n % 10;
                    sum = sum + temp;
                    n = n / 10;
                }
                twoDigitTotal[j] = sum;
            }

            for(int k =0; k < twoDigitTotal.Length; k++)
            {
                if((twoDigitTotal[k]%2) == 1)
                {
                    directionArray[k] = "left";
                } else if((twoDigitTotal[k]%2) == 0)
                {
                    directionArray[k] = "right";
                }else if(twoDigitTotal[k] == 0)
                {
                    directionArray[k] = directionArray[k - 1];
                }
                /*else if(quotientArray[k] == 99 && remainderArray[k] == 999)
                {
                    directionArray[k] = " ";
                }*/
            }

            for(int l =0;l < directionArray.Length; l++)
            {
                if (wordArray[l] == "99999")
                {
                    resultArray[l] = " ";
                }
                resultArray[l] = directionArray[l] + " " + remainderArray[l].ToString();
            }

          /*  for(int z = 0; z < resultArray.Length; z++)
            {
                Console.WriteLine(resultArray[z]);
            } */

            return resultArray;
            
        }
    }
}
