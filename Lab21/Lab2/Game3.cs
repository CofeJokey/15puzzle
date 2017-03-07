using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game3 : Game2
    {
        int LenghtHistory;
        Dictionary<int, Point> Goes = new Dictionary<int, Point>();
        public Game3(int[] Mas,int qe) :base(Mas, qe)
        {
            int i = 0;
            while (i < we * Lenght)
            {

            
         //   for (int i =0; i<we*Lenght;i++)
         //   {
                Goes[i] = GetLoc(i);
            //    Console.WriteLine(Goes[i].x + Goes[i].y);
                i++;
            }
            LenghtHistory = we * Lenght;
        }

public void SaveHistory(int value) 
{
    LenghtHistory++;
    Goes[LenghtHistory] = Goes[value]; 
}


    }

}
