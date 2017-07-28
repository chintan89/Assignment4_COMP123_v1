using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name - Chintan Patel
 * Student # 300622893
 * Date - July 27/2017
 * version 0.1 - Create objects and displayed the result, and implement method WaitforAnyKey
 */
namespace Assignment4_COMP123
{
    class Program
    {
        static void Main(string[] args)
        {
            //7a.Create a new GiantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 136.485, 1889.4, "Gas");

            //7b.method to disply planet's stats to the console
            giantPlanet.ToString();

            //7c.Create a new Terrestrialplanet object
            Terrestrialplanet terrestrialPlanet = new Terrestrialplanet("Earth", 11.998, 6.112, true);

            //7d.method to disply planet's stats to the console
            terrestrialPlanet.ToString();

            //7e. WaitForAnyKey
            Program.WaitforAnyKey();
        }
        //7e. Implemented another method for WaitforAnyKey
        private static void WaitforAnyKey()
        {
            Console.ReadKey();
        }
    }
}
