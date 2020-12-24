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
        /// <summary>
        ///  Initialization of  required variables in the forms 
        /// </summary>
        Graphics g;
        SolidBrush color_fill;
        Pen outline;
        string execution, code, shape;
        int xaxis, yaxis, first_size, second_size,third_size;
        int movex, movey;

        /// <summary>
        /// Variable that are graphically created which is used in drawing shapes or lines.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            g = pnl_draw.CreateGraphics();
            outline = new Pen(Color.Green);
            color_fill = new SolidBrush(Color.Yellow);
            
        }
        /// <summary>
        /// called when color box is clicked, color dialog is called and when selected
        ///  sets the color of the pen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void color_box_Click(object sender, EventArgs e)
        {
            colorselector.ShowDialog();
            color_box.BackColor = colorselector.Color;
            Color dialogcolor = colorselector.Color;
            outline = new Pen(dialogcolor);
        }
        /// <summary>
        /// called when fill box is clicked, color dialog is called and when selected
        ///  sets the color of the fill for the shapes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fill_color_Click(object sender, EventArgs e)
        {
            fillcolorselector.ShowDialog();
            fill_color.BackColor = fillcolorselector.Color;
            Color filldialogcolor = fillcolorselector.Color;
            color_fill = new SolidBrush(filldialogcolor);
        }
        /// <summary>
        /// help Menu. Appears when clicked on help menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(

                "Shape X-axis Y-axis Radius(Or length breadth)" + "\n\n" +
                "Example: \n\n" +
                "Cirlce x-axis y-axis radius" +
                " Rectangle x-axis y-axis length breadth " +
                "Square x-axis y-axis length" +
                 "Triangle x-axis y-axis side1 side2 side3"
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

        /// <summary>
        /// This function loads when the submit button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_btn_Click(object sender, EventArgs e)
        {

           
            if(execution =="clear")
            {
                pnl_draw.Refresh();
            }


            else if (execution == "run")
            {
                this.runcase();
               
            }

            else if(execution == "moveto")
            {
               
                    this.movecase();
                   
                
            }

            else if(execution == "drawto")
            {

                this.drawcase();
            
            }
        }
        /// <summary>
        /// This method is called if the text is run in command input.
        /// This function executes the written multiline command.
        /// </summary>
        private void runcase()
        {
            Color dialogcolor = colorselector.Color;
            outline = new Pen(dialogcolor);
            Color filldialogcolor = fillcolorselector.Color;
            color_fill = new SolidBrush(filldialogcolor);
            String[] code_part = code.Split(' ');
            if (code_part.Length < 4)
            {
                MessageBox.Show("Incorrect Parameter");
            }
            else
            {
                
                switch (shape)
                {
                    case "circle":


                        if (code_part.Length != 4)
                        {
                            String shape_name = "circle";
                            myMethod(shape_name);
                        }
                        foreach (string parts in code_part)
                        {
                            shape = code_part[0];
                            xaxis = Int32.Parse(code_part[1]);
                            yaxis = Int32.Parse(code_part[2]);
                            first_size = Int32.Parse(code_part[3]);

                        }
                        try
                        {
                            Circle cir = new Circle();
                            cir.Draw(g, outline, xaxis, yaxis, first_size);
                            cir.fill(g, color_fill, xaxis, yaxis, first_size);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        break;

                    case "square":

                        if (code_part.Length != 4)
                        {
                            String shape_name = "square";
                            myMethod(shape_name);
                        }
                        foreach (string parts in code_part)
                        {
                            shape = code_part[0];
                            xaxis = Int32.Parse(code_part[1]);
                            yaxis = Int32.Parse(code_part[2]);
                            first_size = Int32.Parse(code_part[3]);

                        }
                        try 
                        { 
                            Square sq = new Square();
                            sq.Draw(g, outline, xaxis, yaxis, first_size);
                            sq.fill(g, color_fill, xaxis, yaxis, first_size);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        break;
                    case "rectangle":
                        if (code_part.Length != 5)
                        {
                            String shape_name = "rectangle";
                            myMethod(shape_name);
                        }
                        foreach (string parts in code_part)
                        {
                            shape = code_part[0];
                            xaxis = Int32.Parse(code_part[1]);
                            yaxis = Int32.Parse(code_part[2]);
                            first_size = Int32.Parse(code_part[3]);

                        }
                        second_size = Int32.Parse(code_part[4]);

                        try 
                        {
                            Rectangle rect = new Rectangle();
                            rect.Draw(g, outline, xaxis, yaxis, first_size, second_size);
                            rect.fill(g, color_fill, xaxis, yaxis, first_size, second_size);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case "triangle":

                        first_size = Int32.Parse(code_part[3]);
                        second_size = Int32.Parse(code_part[4]);
                        third_size = Int32.Parse(code_part[5]);
                        try
                        { 
                            Triangle tr = new Triangle();
                            tr.Draw(g, outline, xaxis, yaxis, first_size, second_size, third_size);
                            tr.fill(g, color_fill, xaxis, yaxis, first_size, second_size, third_size);
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        break;
                }
            }
        }
        /// <summary>
        /// This method is called if the text is moveto in command input.
        /// This function moves the line point value to input points
        /// </summary>
        private void movecase()
        {
            Color dialogcolor = colorselector.Color;
            outline = new Pen(dialogcolor);
            Color filldialogcolor = fillcolorselector.Color;
            color_fill = new SolidBrush(filldialogcolor);
            String[] code_part = code.Split(' ');
            if (code_part.Length != 2)
            {
                MessageBox.Show("Incorrect Parameter");
            }
            else
            {
                pnl_draw.Refresh();
                movex = Int32.Parse(code_part[0]);
                movey = Int32.Parse(code_part[1]);
            }
        }
        /// <summary>
        /// This method is called if the text is drawto in command input.
        /// This function draw the line point value from move to points to input points
        /// </summary>
        private void drawcase()
        {
            Color dialogcolor = colorselector.Color;
            outline = new Pen(dialogcolor);
            Color filldialogcolor = fillcolorselector.Color;
            color_fill = new SolidBrush(filldialogcolor);
            String[] code_part = code.Split(' ');
            if (code_part.Length != 2)
            {
                MessageBox.Show("Incorrect Parameter");
            }
            else
            {
                Point point1 = new Point(0, 0);
                if (movex >= 0 || movey >= 0)
                {
                
                     point1 = new Point(movex, movey);
                    
                }
               
                int drawx = Int32.Parse(code_part[0]);
                int drawy = Int32.Parse(code_part[1]);
                Point point2 = new Point(drawx, drawy);

                g.DrawLine(outline, point1, point2);


            }
        }
        /// <summary>
        /// this method is called if the parameter is not proper in the multiline command input
        /// Shows messagebox with message to input parameters correctly 
        /// </summary>
        /// <param name="shape"></param>
        static void myMethod(string shape)
        {
            String circleMessage = "All parameter must be given properly in such format: \"circle  x-axis y-axis radius";
            String squareMessage = "All parameter must be given properly in such format: \"square  x-axis y-axis length ";
            String rectmessage = "All parameter must be given properly in such format: \"rectangle  x-axis y-axis length breadth";
            if (shape == "circle")
            {
                MessageBox.Show(circleMessage);
            }
            else if( shape == "rectangle")
            {
                MessageBox.Show(rectmessage);
            }
            else if( shape== "square")
            {
                MessageBox.Show(squareMessage);
            }
        }
    }
}
