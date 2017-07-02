namespace mobile
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
            this.tb_WriteHere = new System.Windows.Forms.TextBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_Erase = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_star = new System.Windows.Forms.Button();
            this.btn_sharp = new System.Windows.Forms.Button();
            this.btn_fw = new System.Windows.Forms.Button();
            this.btn_sw = new System.Windows.Forms.Button();
            this.btn_tw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_WriteHere
            // 
            this.tb_WriteHere.Location = new System.Drawing.Point(12, 12);
            this.tb_WriteHere.Multiline = true;
            this.tb_WriteHere.Name = "tb_WriteHere";
            this.tb_WriteHere.ReadOnly = true;
            this.tb_WriteHere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_WriteHere.Size = new System.Drawing.Size(260, 171);
            this.tb_WriteHere.TabIndex = 0;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(129, 220);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(29, 35);
            this.btn_up.TabIndex = 1;
            this.btn_up.Text = "▲";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(129, 287);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(29, 35);
            this.btn_down.TabIndex = 2;
            this.btn_down.Text = "▼";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(164, 254);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(29, 35);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "►";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(94, 254);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(29, 35);
            this.btn_left.TabIndex = 4;
            this.btn_left.Text = "◄";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_Erase
            // 
            this.btn_Erase.Location = new System.Drawing.Point(14, 303);
            this.btn_Erase.Name = "btn_Erase";
            this.btn_Erase.Size = new System.Drawing.Size(75, 23);
            this.btn_Erase.TabIndex = 5;
            this.btn_Erase.Text = "C";
            this.btn_Erase.UseVisualStyleBackColor = true;
            this.btn_Erase.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(199, 303);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(14, 332);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 49);
            this.btn_1.TabIndex = 7;
            this.btn_1.Text = "1 ";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(199, 332);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 49);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3\r\nДЕЖЗ\r\nDEF\r\n";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(14, 387);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 49);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4\r\nИЙКЛ\r\nGHI";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(106, 387);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 49);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5\r\nМНОП\r\nJKL\r\n";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(199, 387);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 49);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6\r\nРСТУ\r\nMNO";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(14, 442);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 54);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7\r\nФХЦЧ\r\nPQRS";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(106, 442);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 54);
            this.btn_8.TabIndex = 13;
            this.btn_8.Text = "8\r\nШЩЪЫ\r\nTUV";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(199, 442);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 54);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9\r\nЬЭЮЯ\r\nWXYZ\r\n";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(106, 332);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 49);
            this.btn_2.TabIndex = 15;
            this.btn_2.Text = "2\r\nАБВГ\r\nABC\r\n";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(106, 502);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 50);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0\r\n[ ]";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_star
            // 
            this.btn_star.Location = new System.Drawing.Point(14, 502);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(75, 50);
            this.btn_star.TabIndex = 17;
            this.btn_star.Text = "*";
            this.btn_star.UseVisualStyleBackColor = true;
            this.btn_star.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_sharp
            // 
            this.btn_sharp.Location = new System.Drawing.Point(199, 502);
            this.btn_sharp.Name = "btn_sharp";
            this.btn_sharp.Size = new System.Drawing.Size(75, 50);
            this.btn_sharp.TabIndex = 18;
            this.btn_sharp.Text = "#";
            this.btn_sharp.UseVisualStyleBackColor = true;
            this.btn_sharp.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_fw
            // 
            this.btn_fw.Location = new System.Drawing.Point(12, 189);
            this.btn_fw.Name = "btn_fw";
            this.btn_fw.Size = new System.Drawing.Size(75, 23);
            this.btn_fw.TabIndex = 19;
            this.btn_fw.UseVisualStyleBackColor = true;
            this.btn_fw.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_sw
            // 
            this.btn_sw.Location = new System.Drawing.Point(106, 189);
            this.btn_sw.Name = "btn_sw";
            this.btn_sw.Size = new System.Drawing.Size(75, 23);
            this.btn_sw.TabIndex = 20;
            this.btn_sw.UseVisualStyleBackColor = true;
            this.btn_sw.Click += new System.EventHandler(this.btn_Actions);
            // 
            // btn_tw
            // 
            this.btn_tw.Location = new System.Drawing.Point(199, 189);
            this.btn_tw.Name = "btn_tw";
            this.btn_tw.Size = new System.Drawing.Size(75, 23);
            this.btn_tw.TabIndex = 21;
            this.btn_tw.UseVisualStyleBackColor = true;
            this.btn_tw.Click += new System.EventHandler(this.btn_Actions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 564);
            this.Controls.Add(this.btn_tw);
            this.Controls.Add(this.btn_sw);
            this.Controls.Add(this.btn_fw);
            this.Controls.Add(this.btn_sharp);
            this.Controls.Add(this.btn_star);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Erase);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.tb_WriteHere);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(300, 603);
            this.MinimumSize = new System.Drawing.Size(300, 603);
            this.Name = "Form1";
            this.Text = "Телефон";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_WriteHere;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_Erase;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.Button btn_sharp;
        private System.Windows.Forms.Button btn_fw;
        private System.Windows.Forms.Button btn_sw;
        private System.Windows.Forms.Button btn_tw;
    }
}

