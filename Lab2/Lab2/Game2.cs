using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game2 :Game, IPlayable
    {
        //int leght = 4;
        //int height = 4;
        public Game2(int el1, int el2, int el3, int el4, int el5, int el6, int el7, int el8,
            int el9, int el10, int el11, int el12, int el13, int el14, int el15, int el16)
            : base( el1, el2,  el3,  el4,  el5,  el6,  el7,  el8,
             el9,  el10,  el11,  el12,  el13,  el14,  el15,  el16)
        {
            

             
        }

        public void RandomValues()
        {
            int tmp = 0;
            items = new Item[16];
            Random rnd = new Random();
            int[] MasNumbers = new int[16];

            for (int i = 0; i < 16; i++)
            {
                bool fl = false;
                do
                {
                    fl = false;
                    tmp = rnd.Next(0, 16);
                    for (int j = 0; j < i; j++)
                    {
                        if (tmp == MasNumbers[j]) { fl = true; }
                    }
                }
                while (fl);
                MasNumbers[i] = tmp;
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    items[i * 4 + j] = new Item(MasNumbers[i * 4 + j], i, j);
                }

            }
        }

        //public override void Shift(int value)
        //{
        //    base.Shift(value);
        //}
        public bool EndGame()
        {
            int i = 0;
           int newvalue = 1;
           while(i < items.Length) 
           { 
                if (items[i].value == newvalue)
                { 
                newvalue++;
                if (newvalue == items.Length) { newvalue = 0; }                   
                }
                else { return false;}
                ++i;
           }
            return true;
        }
    }
}
