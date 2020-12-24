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



        /// <summary>
        ///  /// This function is called from main form class and this function draws circle
        /// </summary>
        /// <param name="g"></param>
        /// <param name="outline"></param>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="first_size"></param>
        public void Draw(Graphics g,Pen outline, int xaxis, int yaxis, int first_size)
        {
            g.DrawEllipse(outline, xaxis, yaxis, first_size, first_size);
        }
        /// <summary>
        ///  /// This function is called from main form class and this function fills circle with 
        /// color
        /// </summary>
        /// <param name="g"></param>
        /// <param name="color_fill"></param>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="first_size"></param>
        public void fill(Graphics g, SolidBrush color_fill, int xaxis, int yaxis, int first_size)
        {
            g.FillEllipse(color_fill, xaxis, yaxis, first_size, first_size);
        }
    }
}
