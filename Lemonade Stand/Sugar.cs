using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Sugar : Items
    
        
    {
                
        int amountOfSugar = 0;

        public Sugar(string name, int cost)
        {
            this.name = name;
            this.price = cost;

        }
        public void AddOneSugar(int amountToAdd)
        {
            amountOfSugar += amountToAdd;

            Console.WriteLine("How much sugar do you want to buy? 1 dollar per sugar.");
            Console.ReadLine();
        }
      
    }
}
        
        //for ( int i = 0; i < Sugar.count; i++)

  //AddOneSugar(67);