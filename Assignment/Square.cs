using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Square
    {


        /// <summary>
        /// This function is called from main form class and this function draws square
        /// </summary>
        /// <param name="g"></param>
        /// <param name="outline"></param>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="first_size"></param>
        public void Draw(Graphics g, Pen outline, int xaxis, int yaxis, int first_size)
        {
            g.DrawRectangle(outline, xaxis, yaxis, first_size, first_size);
        }

        /// <summary>
        ///   This function is called from main form class and this function fills square with 
        /// color
        /// </summary>
        /// <param name="g"></param>
        /// <param name="color_fill"></param>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="first_size"></param>
        public void fill(Graphics g, SolidBrush color_fill, int xaxis, int yaxis, int first_size)
        {
            g.FillRectangle(color_fill, xaxis, yaxis, first_size, first_size);
        }
    }
}
