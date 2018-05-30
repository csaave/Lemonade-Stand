using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{


    class lemon : Items
    {
        int amountOfLemons = 0;
        public lemon(string name, int cost)

        {

            this.name = name;
            this.price = cost;

        }

        public void AddCups(int amountToAdd)

        {

            amountOfLemons += amountToAdd;

            Console.WriteLine("how many cups would you like to buy? 3 dollars per 5 lemons");
            Console.ReadLine();

        }
    }
}
