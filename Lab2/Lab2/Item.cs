using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   
    
    class Item
    {
        public int value;
        public Point point;

        public Item(int el, int x,int y)
        {
            this.value = el;
            this.point = new Point(x, y);
        }

    }
}
