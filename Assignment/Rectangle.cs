using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Rectangle
    {
       

      

        public void Draw(Graphics g, Pen outline, int xaxis, int yaxis, int first_size, int second_size)
        {
            g.DrawRectangle(outline, xaxis, yaxis, first_size, second_size);
        }
        public  void fill(Graphics g, SolidBrush color_fill, int xaxis, int yaxis, int first_size, int second_size )
        {
            g.FillRectangle(color_fill, xaxis, yaxis, first_size, second_size);
        }

        
    }
}
