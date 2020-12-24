namespace Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_draw = new System.Windows.Forms.Panel();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parameter_code = new System.Windows.Forms.TextBox();
            this.execution_plan = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color_box = new System.Windows.Forms.Button();
            this.colorselector = new System.Windows.Forms.ColorDialog();
            this.fill_color = new System.Windows.Forms.Button();
            this.fillcolorselector = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_draw
            // 
            this.pnl_draw.Location = new System.Drawing.Point(208, 70);
            this.pnl_draw.Name = "pnl_draw";
            this.pnl_draw.Size = new System.Drawing.Size(564, 308);
            this.pnl_draw.TabIndex = 0;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(15, 388);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(173, 50);
            this.submit_btn.TabIndex = 1;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Execution Plan";
            // 
            // parameter_code
            // 
            this.parameter_code.Location = new System.Drawing.Point(15, 70);
            this.parameter_code.Multiline = true;
            this.parameter_code.Name = "parameter_code";
            this.parameter_code.Size = new System.Drawing.Size(173, 134);
            this.parameter_code.TabIndex = 4;
            this.parameter_code.TextChanged += new System.EventHandler(this.parameter_code_TextChanged);
            // 
            // execution_plan
            // 
            this.execution_plan.Location = new System.Drawing.Point(12, 236);
            this.execution_plan.Multiline = true;
            this.execution_plan.Name = "execution_plan";
            this.execution_plan.Size = new System.Drawing.Size(173, 55);
            this.execution_plan.TabIndex = 5;
            this.execution_plan.TextChanged += new System.EventHandler(this.execution_plan_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help ";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // color_box
            // 
            this.color_box.Location = new System.Drawing.Point(15, 298);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(75, 23);
            this.color_box.TabIndex = 7;
            this.color_box.Text = "Pen Color ";
            this.color_box.UseVisualStyleBackColor = true;
            this.color_box.Click += new System.EventHandler(this.color_box_Click);
            // 
            // fill_color
            // 
            this.fill_color.Location = new System.Drawing.Point(113, 298);
            this.fill_color.Name = "fill_color";
            this.fill_color.Size = new System.Drawing.Size(75, 23);
            this.fill_color.TabIndex = 8;
            this.fill_color.Text = "Fill Color ";
            this.fill_color.UseVisualStyleBackColor = true;
            this.fill_color.Click += new System.EventHandler(this.fill_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fill_color);
            this.Controls.Add(this.color_box);
            this.Controls.Add(this.execution_plan);
            this.Controls.Add(this.parameter_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.pnl_draw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_draw;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parameter_code;
        private System.Windows.Forms.TextBox execution_plan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button color_box;
        private System.Windows.Forms.ColorDialog colorselector;
        private System.Windows.Forms.Button fill_color;
        private System.Windows.Forms.ColorDialog fillcolorselector;
    }
}

