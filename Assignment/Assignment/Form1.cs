using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush color_fill;
        Pen outline;
        string execution, code, shape;
            int xaxis,yaxis, first_size, second_size;
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
                "Example: \n\n"+
                "cirlce x-axis y-axis radius"+ 
                "\n\n"+"|||||||||||||||||||"+ "\n\n"+
                " Rectangle x-axis y-axis length breadth "+
                "\n\n \n\n "+
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

            String[] code_part = code.Split(' ');
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
                    if (execution == "run")
                    {
                        g.DrawEllipse(outline, xaxis, yaxis, first_size, first_size);
                        g.FillEllipse(color_fill, xaxis, yaxis, first_size, first_size);
                    }

                    if (execution == "clear")
                    {

                    }
                    else
                    {
                        MessageBox.Show("No feature available except run OR clear");
                    }
                    break;

                case "square":
                    if (execution == "run")
                    {
                        g.DrawRectangle(outline, xaxis, yaxis, first_size, first_size);
                        g.FillRectangle(color_fill, xaxis, yaxis, first_size, first_size);
                    }
                    if (execution == "clear")
                    {

                    }
                    else
                    {
                        MessageBox.Show("No feature available except run OR clear");
                    }
                    break;
                case "rectangle":
                    if (execution == "run")
                    {
                        second_size = Int32.Parse(code_part[4]);
                        g.DrawRectangle(outline, xaxis, yaxis, first_size, second_size);
                        g.FillRectangle(color_fill, xaxis, yaxis, first_size, second_size);
                    }
                    if (execution == "clear")
                    {

                    }
                    else
                    {
                        MessageBox.Show("No feature available except run OR clear");
                    }
                    break;
            }
        }
    }
}
