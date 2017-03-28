using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Game
    {
        public int Lenght = 0;
        public Item[] items;
        public readonly int weight = 4;
        //public int NewLength { get; set; }
        public int Length
        {
            get
            {
                return Convert.ToInt32(Math.Sqrt(items.Length)); 
            }
        }

        public Game() { }
        //public Game(params int [] Newlist) 
        //{int ForList=0;
        //for (int i=0; i< 4;i++)
        //{
        //    for (int j=0; j< 4;j++)
        //    {
        //        items[ForList] = new Item(Newlist[ForList], i, j);
        //        ForList++;
        //    }
        //}
        //}

        public Game(int el1, int el2, int el3, int el4, int el5, int el6, int el7, int el8,
            int el9, int el10, int el11, int el12, int el13, int el14, int el15, int el16)
        {
           // NewLength= (int)Math.Sqrt(this.Length);
            items = new Item[] 
            {
                new Item(el1,0,0),
                new Item(el2,0,1),
                new Item(el3,0,2),
                new Item(el4,0,3),

                new Item(el5,1,0),
                new Item(el6,1,1),
                new Item(el7,1,2),
                new Item(el8,1,3),

                new Item(el9,2,0),
                new Item(el10,2,1),
                new Item(el11,2,2),
                new Item(el12,2,3),

                new Item(el13,3,0),
                new Item(el14,3,1),
                new Item(el15,3,2),
                new Item(el16,3,3),
            };
        }

        public Item this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        //public void Print()
        //{
        //    for (int i = 0; i < this.Length; i++)
        //    {
        //        for (int j = 0; j < this.Length; j++)
        //        {
        //            Console.Write("{0,5}", items[i * this.Length + j].value);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}



        public int GetLocation(int value)
        {
            for (int i=0;i<items.Length;i++)
            {
                if (items[i].value==value)
                {
                    return items[i].point.x * this.Length + items[i].point.y;
                }
            }
            return -1;
        }

        public Point GetLocationP(int value)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].value == value)
                {
                    return new Point(items[i].point.x , items[i].point.y);
                }
            }
            return null;
        }
        public int GetSum(int value)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].value == value)
                {
                    return items[i].point.x + items[i].point.y;
                }
            }
            return -1;
        }

        //public Boolean finish() 
        //{
        //    int a = 0;
        //    int b = 0;
        //    return true;
        //}

        public virtual void Shift(int value) // , Game3 games)
        {
            try
            {
                if (value < 0 || value > 15) { throw new ArgumentException(); }
                if (    ((GetLocationP(value).x == GetLocationP(0).x)&&(Math.Abs(GetLocationP(value).y - GetLocationP(0).y)==1))
                    ||  (GetLocationP(value).y == GetLocationP(0).y)&&(Math.Abs(GetLocationP(value).x - GetLocationP(0).x)==1))
                {
                    int tmp;
                    int valueLoction = GetLocation(value);
                    int zeroLocation = GetLocation(0);
                    tmp = items[zeroLocation].value;
                    items[zeroLocation].value = items[valueLoction].value;
                    items[valueLoction].value = tmp;
                //    games.History(value);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Нет такого числа. ");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Некуда двигать. " );
                Console.WriteLine();
            }
          
        }

        public void ShiftBack(int value, Game3 games)
        {
            try
            {
                if (value < 0 || value > 15) { throw new ArgumentException(); }
                if (((GetLocationP(value).x == GetLocationP(0).x) && (Math.Abs(GetLocationP(value).y - GetLocationP(0).y) == 1))
                    || (GetLocationP(value).y == GetLocationP(0).y) && (Math.Abs(GetLocationP(value).x - GetLocationP(0).x) == 1))
                {
                    int tmp;
                    int valueLoction = GetLocation(value);
                    int zeroLocation = GetLocation(0);
                    tmp = items[zeroLocation].value;
                    items[zeroLocation].value = items[valueLoction].value;
                    items[valueLoction].value = tmp;
                   // games.History(value);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Нет такого числа. ");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Некуда двигать. ");
                Console.WriteLine();
            }

        }

    }
}
