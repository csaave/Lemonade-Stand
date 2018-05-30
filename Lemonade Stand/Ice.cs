using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Ice : Items
    {
                
        int amountOfIce = 0;

    public Ice(string name, int cost)
    {
        this.name = name;
        this.price = cost;

    }
    public void AddIce(int amountToAdd)
    {
        amountOfIce += amountToAdd;

        Console.WriteLine("How much ice do you want to buy? 1 dollar per 50 ice.");
        Console.ReadLine();
    }

}
}