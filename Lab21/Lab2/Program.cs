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
          
            int i;
            int[] p = new int[100];

            for (i = 0; i < 16; i++)
            {
                p[i] = i + 1;
            }

            p[15] = 0;
            Game3 game1 = new Game3(p,i);
         //   Game game1 = new Game(p, i);
            game1.RandomValues(p);
            while (true)
            {
                Console.WriteLine("Выберите действие:" + Environment.NewLine + "1 - играть" + Environment.NewLine + "6 - выход");


                try
                {
                    int key = Convert.ToInt16(Console.ReadLine());
                    if (key <= 0 || key > 6) { throw new Exception(); }

                    switch (key)
                    {
                        case 1:

                            for (; ; )
                            {
                           
                                game1.Print();
                                
                                Console.WriteLine("Двигайте цифру ");

                                int a = Convert.ToInt32(Console.ReadLine());

                                game1.Shift(a, game1);
                                
                                if (game1.EndGame())
                                {
                                    game1.Print();
                                    Console.WriteLine("Вы прошли игру");

                                    break;
                                }

                            }
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

            }
        }
    }
}