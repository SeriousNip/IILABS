
namespace Ex1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.el1 = new System.Windows.Forms.TextBox();
            this.el2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addition = new System.Windows.Forms.ToolStripMenuItem();
            this.substraction = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplication = new System.Windows.Forms.ToolStripMenuItem();
            this.division = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.subs = new System.Windows.Forms.ToolStripMenuItem();
            this.mult = new System.Windows.Forms.ToolStripMenuItem();
            this.Div = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // el1
            // 
            this.el1.Location = new System.Drawing.Point(91, 40);
            this.el1.Name = "el1";
            this.el1.Size = new System.Drawing.Size(143, 23);
            this.el1.TabIndex = 0;
            // 
            // el2
            // 
            this.el2.Location = new System.Drawing.Point(520, 40);
            this.el2.Name = "el2";
            this.el2.Size = new System.Drawing.Size(143, 23);
            this.el2.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(303, 310);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(143, 23);
            this.result.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleName = "";
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addition,
            this.substraction,
            this.multiplication,
            this.division});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addition
            // 
            this.addition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add});
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(65, 20);
            this.addition.Text = "Addition";
            // 
            // substraction
            // 
            this.substraction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subs});
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(85, 20);
            this.substraction.Text = "Substraction";
            // 
            // multiplication
            // 
            this.multiplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mult});
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(93, 20);
            this.multiplication.Text = "Multiplication";
            // 
            // division
            // 
            this.division.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Div});
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(61, 20);
            this.division.Text = "Division";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(93, 22);
            this.add.Text = "Use";
            // 
            // subs
            // 
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(93, 22);
            this.subs.Text = "Use";
            // 
            // mult
            // 
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(93, 22);
            this.mult.Text = "Use";
            // 
            // Div
            // 
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(93, 22);
            this.Div.Text = "Use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.el2);
            this.Controls.Add(this.el1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox el1;
        private System.Windows.Forms.TextBox el2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addition;
        private System.Windows.Forms.ToolStripMenuItem substraction;
        private System.Windows.Forms.ToolStripMenuItem multiplication;
        private System.Windows.Forms.ToolStripMenuItem division;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem subs;
        private System.Windows.Forms.ToolStripMenuItem mult;
        private System.Windows.Forms.ToolStripMenuItem Div;
    }
}

