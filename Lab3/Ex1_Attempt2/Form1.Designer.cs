
namespace Ex1_Attempt2
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
            this.lb_Univ = new System.Windows.Forms.ListBox();
            this.lb_Fac = new System.Windows.Forms.ListBox();
            this.tb_Oras = new System.Windows.Forms.TextBox();
            this.tb_Cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Univ
            // 
            this.lb_Univ.FormattingEnabled = true;
            this.lb_Univ.ItemHeight = 15;
            this.lb_Univ.Location = new System.Drawing.Point(12, 56);
            this.lb_Univ.Name = "lb_Univ";
            this.lb_Univ.Size = new System.Drawing.Size(359, 379);
            this.lb_Univ.TabIndex = 0;
            this.lb_Univ.SelectedIndexChanged += new System.EventHandler(this.lb_Univ_SelectedIndexChanged);
            // 
            // lb_Fac
            // 
            this.lb_Fac.FormattingEnabled = true;
            this.lb_Fac.ItemHeight = 15;
            this.lb_Fac.Location = new System.Drawing.Point(377, 56);
            this.lb_Fac.Name = "lb_Fac";
            this.lb_Fac.Size = new System.Drawing.Size(308, 154);
            this.lb_Fac.TabIndex = 1;
            this.lb_Fac.SelectedIndexChanged += new System.EventHandler(this.lb_Fac_SelectedIndexChanged);
            // 
            // tb_Oras
            // 
            this.tb_Oras.Location = new System.Drawing.Point(377, 263);
            this.tb_Oras.Name = "tb_Oras";
            this.tb_Oras.Size = new System.Drawing.Size(308, 23);
            this.tb_Oras.TabIndex = 2;
            // 
            // tb_Cod
            // 
            this.tb_Cod.Location = new System.Drawing.Point(377, 324);
            this.tb_Cod.Name = "tb_Cod";
            this.tb_Cod.Size = new System.Drawing.Size(308, 23);
            this.tb_Cod.TabIndex = 3;
            this.tb_Cod.TextChanged += new System.EventHandler(this.tb_Cod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Universitati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(377, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Facultati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(377, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(377, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cod Universitate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add University";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remove University";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update University Code";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Cod);
            this.Controls.Add(this.tb_Oras);
            this.Controls.Add(this.lb_Fac);
            this.Controls.Add(this.lb_Univ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Univ;
        private System.Windows.Forms.ListBox lb_Fac;
        private System.Windows.Forms.TextBox tb_Oras;
        private System.Windows.Forms.TextBox tb_Cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

