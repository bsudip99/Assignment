using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public abstract class Shape
    {
    /// <summary>
    /// Passing different value 
    /// </summary>
    /// <param name="g"></param>
    /// <param name="outline"></param>
    /// <param name="xaxis"></param>
    /// <param name="yaxis"></param>
    /// <param name="first_size"></param>
    /// <param name="second_size"></param>
        public abstract void Draw(Graphics g, Pen outline, int xaxis, int yaxis, int first_size, int second_size);

   
    }
}
