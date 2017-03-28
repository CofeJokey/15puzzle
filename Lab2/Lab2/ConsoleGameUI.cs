using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ConsoleGameUI
    {
        IPlayable Game4;

        public ConsoleGameUI(IPlayable games)
        {
            Game4 = games;
        }

        public void GameShow()
        {
            Console.WriteLine(Game4);
        }

        public void Shift()
        {
            Game4.Shift(Convert.ToInt32(Console.ReadLine()));
        }



    }


}