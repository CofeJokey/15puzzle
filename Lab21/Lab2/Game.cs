using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab2
{
    class Game
    {
    //    protected Item[] items;
        const int we = 4, be = 4;
        int[,] TtemsNew = new int[we, be];
        Point[] TtemsValue = new Point[100];
        int[] Mas = new int[100];
    public static int[] ListMass = new int[100];
      

        public Game(int[] Mas) {
            int ae = 0;
            ReaderCSV();
            //RandomValues(Mas);
            for (int i = 0; i <we; i++)
            {
                for(int j=0; j<be; j++)
                {
                    TtemsNew[i, j] = Mas[ae];
                    TtemsValue[Mas[ae]] = new Point(i, j);
                    ae++;
                }
            }
        }
        private Point GetLoc(int value)
        {
            return TtemsValue[value];
        }
      
        public void Print()
        {
            for (int i = 0; i < we; i++)
            {
                for (int j = 0; j < be; j++)
                {
                    Console.Write("{0,5}",TtemsNew[i,j]);

                }
                Console.WriteLine();
            }

        }
        
        public void Shift(int value) 
    { 

    try 
    { 
    Console.WriteLine(value);
    if (value < 0 || value > 15) { throw new ArgumentException(); }
    

    int x = GetLoc(0).x;
    int y = GetLoc(0).y;

    int ValueX = GetLoc(value).x;
    int ValueY = GetLoc(value).y; 

    if ((ValueX == x && (ValueY == y - 1 || ValueY == y + 1))
        ||(ValueY == y && (ValueX == x - 1 || ValueX == x + 1))) 
    {

    TtemsNew[x, y] = value;
    TtemsNew[ValueX, ValueY] = 0; 

    var vere = TtemsValue[0];
    TtemsValue[0] = TtemsValue[value];
    TtemsValue[value] = vere; 
    } 

     else 
        { 
        throw new Exception(); 
        } 
    } 

    catch (ArgumentException e) 
    {
        Console.WriteLine("Нет такого числа. ");
        Console.WriteLine(); 
    } 
    catch (Exception e) 
    {
        Console.WriteLine("Некуда двигать. ");
        Console.WriteLine();
    } 

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



        public Boolean EndGame()
        {
            bool fl = false;
            int value = 0;
            for (int i = 0; i < we; ++i)
            {
                for (int j = 0; j < be; ++j)
                {
                    if (TtemsNew[i, j] == value)
                    {

                        fl = true;
                    }
                    else
                    {
                        fl = false;
                    }
                    ++value;
                }

            }
            if (TtemsNew[we - 1, be - 1] == 0)
            {
                fl = true;
            }
            else
            {
                return false;
            }

            return fl;

        }

        public static int ReaderCSV()
        {
            int perem = 0;
            string[] List = File.ReadAllLines(@"C:\Users\Илья\Desktop\ForGIT\Lab2\Lab21\15puzzle\Lab21\Lab2\List.csv");
            Char qe = ' '; 
        
        for (int i = 0; i < List.Length; ++i) 
        {
            string[] ListStr = List[i].Split(qe);
            foreach (var Listsubstr in ListStr) 
        {
            ListMass[perem] = Convert.ToInt32(Listsubstr); 
       // Console.WriteLine(areaChik[integer]); 
            ++perem; 
        } 
        }
        return perem;
        }
      
    }
}
