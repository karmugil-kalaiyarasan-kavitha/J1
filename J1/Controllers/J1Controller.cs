using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace J1.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/j1/menu/{burger}/{drink}/{side}/{dessert}")]
        // GET: api/j1/menu/{burger}/{drink}/{side}/{dessert}
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int burgerCalories;
            int drinkCalories;
            int sideCalories;
            int dessertCalories;
            int totalCalories;
            /* if (burger > 0 && burger < 5)
             {
                 if (burger == 1)
                 {
                     burgerCalories = 461;
                 }
                 else if (burger == 2)
                 {
                     burgerCalories = 431;
                 }
                 else if (burger == 3)
                 {
                     burgerCalories = 420;
                 }
                 else
                 {
                     burgerCalories = 0;
                 }
                 return burgerCalories;
             }
             if (drink > 0 && drink < 5)
             {
                 if (drink == 1)
                 {
                     drinkCalories = 130;
                 }
                 else if (drink == 2)
                 {
                     drinkCalories = 160;
                 }
                 else if (drink == 3)
                 {
                     drinkCalories = 118;
                 }
                 else
                 {
                     drinkCalories = 0;
                 }
             }
             if (side > 0 && side < 5)
             {
                 if (side == 1)
                 {
                     sideCalories = 100;
                 }
                 else if (side == 2)
                 {
                     sideCalories = 57;
                 }
                 else if (side == 3)
                 {
                     sideCalories = 70;
                 }
                 else
                 {
                     sideCalories = 0;
                 }
             }
             if (dessert > 0 && dessert < 5)
             {
                 if (dessert == 1)
                 {
                     dessertCalories = 167;
                 }
                 else if (dessert == 2)
                 {
                     dessertCalories = 266;
                 }
                 else if (dessert == 3)
                 {
                     dessertCalories = 75;
                 }
                 else
                 {
                     dessertCalories = 0;
                 }
             }
             totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;
             return totalCalories;*/
            switch (burger)
            {
                case 1:
                    burgerCalories = 461;
                    break;
                case 2:
                    burgerCalories = 431;
                    break;
                case 3:
                    burgerCalories = 420;
                    break;
                default:
                    burgerCalories = 0;
                    break;
            }
            switch (drink)
            {
                case 1:
                    drinkCalories = 130;
                    break;
                case 2:
                    drinkCalories = 160;
                    break;
                case 3:
                    drinkCalories = 118;
                    break;
                default:
                    drinkCalories = 0;
                    break;
            }
            switch (side)
            {
                case 1:
                    sideCalories = 100;
                    break;
                case 2:
                    sideCalories = 57;
                    break;
                case 3:
                    sideCalories = 70;
                    break;
                default:
                    sideCalories = 0;
                    break;
            }
            switch (dessert)
            {
                case 1:
                    dessertCalories = 167;
                    break;
                case 2:
                    dessertCalories = 266;
                    break;
                case 3:
                    dessertCalories = 75;
                    break;
                default:
                    dessertCalories = 0;
                    break;
            }
            totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;
             return "Your total calorie count is " + totalCalories.ToString();
        }



    }
}
