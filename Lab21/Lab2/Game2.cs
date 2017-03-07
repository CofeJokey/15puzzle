using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game2 : Game
    {


       

        public Game2(int[] Mas,int qe) :base(Mas, qe) 
        {
            //Lenght = qe;
            //int ae = 0;
          
            //RandomValues(Mas);
            //for (int i = 0; i <we; i++)
            //{
            //    for(int j=0; j<be; j++)
            //    {
            //        TtemsNew[i, j] = Mas[ae];
            //        TtemsValue[Mas[ae]] = new Point(i, j);
            //        ae++;
            //    }
            //}
        }

        public Boolean EndGame()
        {
            bool fl = false;
            int value = 1;
            for (int i = 0; i < we; ++i)
            {
                for (int j = 0; j < be; ++j)
                {
                    if (TtemsNew[i, j] == value)
                    {

                        fl = true;
                        value++;
                        if (value == Lenght)
                        {
                            value = 0;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }


            }
            return fl;
        }


        public void RandomValues(int[] Mas)
        {
            int tmp = 0;
            Random rnd = new Random();

            for (int i = 0; i < 16; i++)
            {
                bool isExist = false;
                do
                {
                    isExist = false;
                    tmp = rnd.Next(0, 16);
                    for (int j = 0; j < i; j++)
                    {
                        if (tmp == Mas[j]) { isExist = true; }
                    }
                }
                while (isExist);
                Mas[i] = tmp;
            }
        }




    }
}