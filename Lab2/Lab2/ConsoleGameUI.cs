using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ConsoleGameUI
    {
        IPlayable IPLAY;
        public int width = 4;
        public ConsoleGameUI(IPlayable games)
        {
            IPLAY = games;
        }

        public void Print()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("{0,5}", items[i * width + j].value);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }






        public void Shift()
        {
            IPLAY.Shift(Convert.ToInt32(Console.ReadLine()));
        }


        public void PlayGame()
        {

           //IPLAY.RandomValues();
            Console.WriteLine("***** Игра в 15 ****");
            Console.WriteLine();
            Print();
            while (true)
            {
                Console.WriteLine("Выберите действие:" + Environment.NewLine + "1 - играть" + Environment.NewLine + "2 - отмена хода" + Environment.NewLine + "6 - выход");


                try
                {
                    int key = Convert.ToInt16(Console.ReadLine());
                    if (key <= 0 || key > 6) { throw new Exception(); }

                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Двигайте цифру");
                            int NewValue = Convert.ToInt16(Console.ReadLine());
                            IPLAY.Shift(NewValue); //,game4);
                            Print();
                            if (IPLAY.EndGame())
                            {
                                // game4.Print();
                                Console.WriteLine("Вы прошли игру");
                                break;
                            }
                           
                            

                            break;

                        case 2:

                            //NewStepBack();
                            Print();

                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }




                catch
                {
                    Console.WriteLine("Недопустимый символ, попробуйте еще раз");
                }

                //if (game4.EndGame())
                //{
                //    game4.Print();
                //    Console.WriteLine("Вы прошли игру");

                //}

            }


        }

    }


}