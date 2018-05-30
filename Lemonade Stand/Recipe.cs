using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Recipe : Inventory
    {
        private int lemon = 5;
        private int Ice = 5;
        private int Sugar = 5;

        public int Lemon { get { return lemon; } set { lemon = value; } }
        public int sugar { get { return sugar; } set { sugar = value; } }
        public int ice { get { return ice; } set { ice = value; } }
        
    }
}
