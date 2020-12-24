using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Triangle
    {

        Graphics g;
        /// <summary>
        ///  This function is called from main form class and this function draws triangle 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="outline"></param>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="first_size"></param>
        /// <param name="second_size"></param>
        /// <param name="third_size"></param>
        public void Draw(Graphics g, Pen outline, int xaxis, int yaxis, int first_size, int second_size,int third_size)
        {
            g.DrawLine(outline, xaxis, yaxis, first_size, yaxis);

            g.DrawLine(outline, xaxis, yaxis, xaxis, second_size);
            g.DrawLine(outline, first_size, yaxis, xaxis, second_size);
            return;
        }

        /// <summary>
        ///  /// This function is called from main form class and this function fills triangle with 
        /// color
        /// </summary>
        /// <param name="g"></param>
        /// <param name="color_fill"></param>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <param name="first_size"></param>
        /// <param name="second_size"></param>
        /// <param name="third_size"></param>
        public void fill(Graphics g, SolidBrush color_fill, int xaxis, int yaxis, int first_size, int second_size , int third_size)
        {
            Point point1 = new Point(xaxis, yaxis);
            Point point2 = new Point(xaxis, second_size);
            Point point3 = new Point(first_size, yaxis);
            Point[] allpoints = { point1, point2, point3 };

            g.FillPolygon(color_fill, allpoints);
        }
    }
}
