using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public int NumberOfDays = 7;
        public string choice;
        public Game() {
        }
        public void StartGame(){
            PlayGame();
        }
        public void PlayGame()
        {
            Console.WriteLine("Would you like to play Lemonade Stand?");

        }
        public void ChooseName()
        {
            Console.WriteLine("Please Enter Name");
            Console.ReadLine();


        }
    }
}
