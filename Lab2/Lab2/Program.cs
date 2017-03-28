using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Game game3 = new Game(7, 8, 0, 2, 3, 1, 4, 6, 5, 9, 10, 11, 12, 13, 14, 15);
            Game3 game4 = new Game3(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15);
         //   Game2 game = new Game2();
            ConsoleGameUI PLAY = new ConsoleGameUI(game4);
            PLAY.PlayGame();
           
            
        }
    }

   
}