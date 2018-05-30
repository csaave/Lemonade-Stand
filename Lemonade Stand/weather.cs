using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class weather
    {
        

        Random rnd = new Random();
        string[] forecast = { "rain", "overcast", "sunny", "cloudy" };
        


        Random degrees = new Random();
        public void GetWeather()
        {
            int rand = degrees.Next(50, 100);
            Console.WriteLine("");
        }

            
    }
}
