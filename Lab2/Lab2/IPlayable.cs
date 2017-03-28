using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface IPlayable
    {
        void RandomValues();
        bool EndGame();
        void Shift(int value);
    //    int NewValue { get; }
      //  int this[int index] { get; set; }
    }

}