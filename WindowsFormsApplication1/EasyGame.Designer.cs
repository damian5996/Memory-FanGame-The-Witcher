namespace WindowsFormsApplication1
{
    partial class EasyGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyGame));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Label();
            this.BACK2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(59, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 206);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(292, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 206);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(526, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 206);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(59, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 206);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(292, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 206);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(526, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 206);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chiller", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(832, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 61);
            this.label1.TabIndex = 13;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Chiller", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(700, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 111);
            this.label2.TabIndex = 14;
            this.label2.Text = "Your score:";
            // 
            // BACK
            // 
            this.BACK.AutoSize = true;
            this.BACK.BackColor = System.Drawing.Color.Transparent;
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.Red;
            this.BACK.Location = new System.Drawing.Point(2, 538);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(134, 48);
            this.BACK.TabIndex = 20;
            this.BACK.Text = "BACK";
            this.BACK.MouseEnter += new System.EventHandler(this.BACK_MouseEnter);
            // 
            // BACK2
            // 
            this.BACK2.AutoSize = true;
            this.BACK2.BackColor = System.Drawing.Color.Transparent;
            this.BACK2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK2.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK2.ForeColor = System.Drawing.Color.DarkRed;
            this.BACK2.Location = new System.Drawing.Point(2, 538);
            this.BACK2.Name = "BACK2";
            this.BACK2.Size = new System.Drawing.Size(134, 48);
            this.BACK2.TabIndex = 21;
            this.BACK2.Text = "BACK";
            this.BACK2.Click += new System.EventHandler(this.BACK2_Click);
            this.BACK2.MouseLeave += new System.EventHandler(this.BACK2_MouseLeave);
            // 
            // EasyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.BACK2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasyGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Witcher: Memory Game";
            this.Load += new System.EventHandler(this.EasyGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BACK;
        private System.Windows.Forms.Label BACK2;
    }
}