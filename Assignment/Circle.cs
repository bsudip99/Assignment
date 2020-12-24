using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Circle
    {
       
       
      

        public void Draw(Graphics g,Pen outline, int xaxis, int yaxis, int first_size)
        {
            g.DrawEllipse(outline, xaxis, yaxis, first_size, first_size);
        }
        public void fill(Graphics g, SolidBrush color_fill, int xaxis, int yaxis, int first_size)
        {
            g.FillEllipse(color_fill, xaxis, yaxis, first_size, first_size);
        }
    }
}
