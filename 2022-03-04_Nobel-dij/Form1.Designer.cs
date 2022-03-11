
namespace _2022_03_04_Nobel_dij
{
    partial class OrvosiNobeldijasokGUI
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
            this.btnMentés = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.év = new System.Windows.Forms.Label();
            this.név = new System.Windows.Forms.Label();
            this.szh = new System.Windows.Forms.Label();
            this.orszag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMentés
            // 
            this.btnMentés.Location = new System.Drawing.Point(133, 289);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(104, 20);
            this.btnMentés.TabIndex = 0;
            this.btnMentés.Text = "Adatok mentése";
            this.btnMentés.UseVisualStyleBackColor = true;
            this.btnMentés.Click += new System.EventHandler(this.btnMentés_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 20);
            this.textBox4.TabIndex = 4;
            // 
            // év
            // 
            this.év.AutoSize = true;
            this.év.Location = new System.Drawing.Point(38, 108);
            this.év.Name = "év";
            this.év.Size = new System.Drawing.Size(23, 13);
            this.év.TabIndex = 5;
            this.év.Text = "Év:";
            // 
            // név
            // 
            this.név.AutoSize = true;
            this.név.Location = new System.Drawing.Point(38, 150);
            this.név.Name = "név";
            this.név.Size = new System.Drawing.Size(30, 13);
            this.név.TabIndex = 6;
            this.név.Text = "Név:";
            // 
            // szh
            // 
            this.szh.AutoSize = true;
            this.szh.Location = new System.Drawing.Point(38, 194);
            this.szh.Name = "szh";
            this.szh.Size = new System.Drawing.Size(32, 13);
            this.szh.TabIndex = 7;
            this.szh.Text = "Sz/H";
            // 
            // orszag
            // 
            this.orszag.AutoSize = true;
            this.orszag.Location = new System.Drawing.Point(38, 232);
            this.orszag.Name = "orszag";
            this.orszag.Size = new System.Drawing.Size(46, 13);
            this.orszag.TabIndex = 8;
            this.orszag.Text = "Ország: ";
            // 
            // OrvosiNobeldijasokGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orszag);
            this.Controls.Add(this.szh);
            this.Controls.Add(this.név);
            this.Controls.Add(this.év);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMentés);
            this.Name = "OrvosiNobeldijasokGUI";
            this.Text = "Orvosi Nobel-díjasok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMentés;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label év;
        private System.Windows.Forms.Label név;
        private System.Windows.Forms.Label szh;
        private System.Windows.Forms.Label orszag;
    }
}

