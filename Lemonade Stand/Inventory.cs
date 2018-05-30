using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory : player
    {
        Sugar sugar = new Sugar("Sugar", 1);
        Ice ice = new Ice("Ice", 1);
        cups cups = new cups("Cups", 2);
        lemon Lemon = new lemon("lemon", 3);
    }
    public class wallet
    {

    }
    public class expiration
    {
        public int daysExpire;
        public int DaysExpire;

    }
}
