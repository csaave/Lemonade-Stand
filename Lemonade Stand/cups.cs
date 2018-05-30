using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class cups : Items
    {
        int amountOfCups = 0;
        public cups(string name, int cost)

        {

            this.name = name;
            this.price = cost;

        }

        public void AddCups(int amountToAdd)

        {

            amountOfCups += amountToAdd;

            Console.WriteLine("how many cups would you like to buy? 2 dollars per 10 cups");
            Console.ReadLine();

        }
    }
}
