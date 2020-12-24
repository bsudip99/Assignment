using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Assignment
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush color_fill;
        Pen outline;
        string execution, code, shape;
        int xaxis, yaxis, first_size, second_size,third_size;
        public Form1()
        {
            InitializeComponent();
            g = pnl_draw.CreateGraphics();
            outline = new Pen(Color.Green);
            color_fill = new SolidBrush(Color.Yellow);
        }



        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(

                "Shape X-axis Y-axis Radius(Or length breadth)" + "\n\n" +
                "Example: \n\n" +
                "cirlce x-axis y-axis radius" +
                "\n\n" + "|||||||||||||||||||" + "\n\n" +
                " Rectangle x-axis y-axis length breadth " +
                "\n\n \n\n " +
                "Square x-axis y-axis length"
                );
        }


        private void execution_plan_TextChanged(object sender, EventArgs e)
        {
            execution = execution_plan.Text.ToLower();
        }

        private void parameter_code_TextChanged(object sender, EventArgs e)
        {
            code = parameter_code.Text.ToLower();
        }


        private void submit_btn_Click(object sender, EventArgs e)
        {

           
            if(execution =="clear")
            {
                pnl_draw.Refresh();
            }


            if (execution == "run")
            {

                String[] code_part = code.Split(' ');
                if (code_part.Length < 4)
                {
                    MessageBox.Show("Incorrect Parameter");
                }
                else
                {
                    foreach (string parts in code_part)
                    {
                        shape = code_part[0];
                        xaxis = Int32.Parse(code_part[1]);
                        yaxis = Int32.Parse(code_part[2]);
                        first_size = Int32.Parse(code_part[3]);

                    }
                    switch (shape)
                    {
                        case "circle":
                            String Circlemessage = "All parameter must be given properly in such format: \"circle  x-axis y-axis radius";
                            if (String.IsNullOrEmpty(xaxis.ToString()) || String.IsNullOrEmpty(yaxis.ToString()) || String.IsNullOrEmpty(first_size.ToString()))
                            {
                                MessageBox.Show(Circlemessage);
                            }
                            Circle cir = new Circle();
                            cir.Draw(g,outline, xaxis, yaxis, first_size);
                            cir.fill(g,color_fill, xaxis, yaxis, first_size);
                            //g.DrawEllipse(outline, xaxis, yaxis, first_size, first_size);
                            //g.FillEllipse(color_fill, xaxis, yaxis, first_size, first_size);


                            break;

                        case "square":
                            String squaremessage = "All parameter must be given properly in such format: \"square  x-axis y-axis length";
                            if (String.IsNullOrEmpty(xaxis.ToString()) || String.IsNullOrEmpty(yaxis.ToString()) || String.IsNullOrEmpty(first_size.ToString()))
                            {
                                MessageBox.Show(squaremessage);
                            }
                            Square sq = new Square();
                            sq.Draw(g,outline, xaxis, yaxis, first_size);
                            sq.fill(g,color_fill, xaxis, yaxis, first_size);
                            //g.DrawRectangle(outline, xaxis, yaxis, first_size, first_size);
                            //g.FillRectangle(color_fill, xaxis, yaxis, first_size, first_size);

                            break;
                        case "rectangle":

                            second_size = Int32.Parse(code_part[4]);
                            String rectmessage = "All parameter must be given properly in such format: \"rectangle  x-axis y-axis length breadth";
                            if (String.IsNullOrEmpty(xaxis.ToString()) || String.IsNullOrEmpty(yaxis.ToString()) || String.IsNullOrEmpty(first_size.ToString()))
                            {
                                MessageBox.Show(rectmessage);
                            }
                            Rectangle rect = new Rectangle();
                            rect.Draw(g,outline, xaxis, yaxis, first_size, second_size);
                            rect.fill(g,color_fill, xaxis, yaxis, first_size, second_size);
                            //g.DrawRectangle(outline, xaxis, yaxis, first_size, second_size);
                            //g.FillRectangle(color_fill, xaxis, yaxis, first_size, second_size);
                            break;

                        case "triangle":
                            first_size = Int32.Parse(code_part[3]);
                            second_size = Int32.Parse(code_part[4]);
                            third_size = Int32.Parse(code_part[5]);
                            Triangle tr = new Triangle();
                            tr.Draw(g,outline, xaxis, yaxis, first_size, second_size, third_size);
                            tr.fill(g,color_fill, xaxis, yaxis, first_size, second_size, third_size);
                            //int x1 = (Int32)((first_size ^ 2) + (third_size ^ 2) - (second_size ^ 2)) / (2*first_size);
                            //int y1 = (Int32)Math.Round(Math.Sqrt(Math.Abs(third_size ^ 2 - x1 ^ 2)));

                            //int x2 = (Int32)((first_size ^ 2) + (second_size ^ 2) - (third_size ^ 2)) / (2 * first_size);
                            //int y2 = (Int32)Math.Round(Math.Sqrt(Math.Abs(second_size ^ 2 - x2 ^ 2)));
                            //g.DrawLine(outline, xaxis, yaxis, x1, y1);

                            //g.DrawLine(outline, x1, y1, x2, y2);
                            //g.DrawLine(outline, x2, y2, xaxis, yaxis);

                            //g.DrawLine(outline, xaxis, yaxis, first_size, yaxis);

                            //g.DrawLine(outline, xaxis, yaxis, xaxis, second_size);
                            //g.DrawLine(outline, first_size, yaxis, xaxis, second_size);
                            //Point point1 = new Point(xaxis, yaxis);
                            //Point point2 = new Point(xaxis, second_size);
                            //Point point3 = new Point(first_size, yaxis);
                            //Point[] allpoints = { point1, point2, point3 };

                            //g.FillPolygon(color_fill, allpoints);


                            break;
                    }
                }
            }

            if(execution == "moveto")
            {
                String[] code_part = code.Split(' ');
                if (code_part.Length != 2)
                {
                    MessageBox.Show("Incorrect Parameter");
                }
                else { 
                    pnl_draw.Refresh();
                    xaxis = Int32.Parse(code_part[0]);
                    yaxis = Int32.Parse(code_part[1]);
                    //moveTo(x, y);
                    }
            }

            if(execution == "drawto")
            {
                String[] code_part = code.Split(' ');
                if (code_part.Length != 2)
                {
                    MessageBox.Show("Incorrect Parameter");
                }
                else
                {
                    pnl_draw.Refresh();
                    xaxis = Int32.Parse(code_part[0]);
                    yaxis = Int32.Parse(code_part[1]);
                    //moveTo(x, y);
                }
            }
        }
    }
}
