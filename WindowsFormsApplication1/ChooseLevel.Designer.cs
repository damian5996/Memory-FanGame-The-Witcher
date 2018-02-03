namespace WindowsFormsApplication1
{
    partial class ChooseLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevel));
            this.LVL = new System.Windows.Forms.Label();
            this.EASY = new System.Windows.Forms.Label();
            this.NORMAL = new System.Windows.Forms.Label();
            this.HARD = new System.Windows.Forms.Label();
            this.EASY2 = new System.Windows.Forms.Label();
            this.NORMAL2 = new System.Windows.Forms.Label();
            this.HARD2 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Label();
            this.EXIT2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LVL
            // 
            this.LVL.AutoSize = true;
            this.LVL.BackColor = System.Drawing.Color.Transparent;
            this.LVL.Font = new System.Drawing.Font("Chiller", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVL.ForeColor = System.Drawing.Color.Red;
            this.LVL.Location = new System.Drawing.Point(710, 43);
            this.LVL.Name = "LVL";
            this.LVL.Size = new System.Drawing.Size(341, 69);
            this.LVL.TabIndex = 0;
            this.LVL.Text = "CHOOSE LEVEL";
            // 
            // EASY
            // 
            this.EASY.AutoSize = true;
            this.EASY.BackColor = System.Drawing.Color.Transparent;
            this.EASY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EASY.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EASY.ForeColor = System.Drawing.Color.Red;
            this.EASY.Location = new System.Drawing.Point(822, 156);
            this.EASY.Name = "EASY";
            this.EASY.Size = new System.Drawing.Size(108, 56);
            this.EASY.TabIndex = 1;
            this.EASY.Text = "EASY";
            this.EASY.MouseEnter += new System.EventHandler(this.EASY_MouseEnter);
            // 
            // NORMAL
            // 
            this.NORMAL.AutoSize = true;
            this.NORMAL.BackColor = System.Drawing.Color.Transparent;
            this.NORMAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NORMAL.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NORMAL.ForeColor = System.Drawing.Color.Red;
            this.NORMAL.Location = new System.Drawing.Point(797, 260);
            this.NORMAL.Name = "NORMAL";
            this.NORMAL.Size = new System.Drawing.Size(168, 56);
            this.NORMAL.TabIndex = 2;
            this.NORMAL.Text = "NORMAL";
            this.NORMAL.MouseEnter += new System.EventHandler(this.NORMAL_MouseEnter);
            // 
            // HARD
            // 
            this.HARD.AutoSize = true;
            this.HARD.BackColor = System.Drawing.Color.Transparent;
            this.HARD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HARD.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HARD.ForeColor = System.Drawing.Color.Red;
            this.HARD.Location = new System.Drawing.Point(822, 366);
            this.HARD.Name = "HARD";
            this.HARD.Size = new System.Drawing.Size(113, 56);
            this.HARD.TabIndex = 3;
            this.HARD.Text = "HARD";
            this.HARD.MouseEnter += new System.EventHandler(this.HARD_MouseEnter);
            // 
            // EASY2
            // 
            this.EASY2.AutoSize = true;
            this.EASY2.BackColor = System.Drawing.Color.Transparent;
            this.EASY2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EASY2.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EASY2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EASY2.Location = new System.Drawing.Point(822, 156);
            this.EASY2.Name = "EASY2";
            this.EASY2.Size = new System.Drawing.Size(108, 56);
            this.EASY2.TabIndex = 5;
            this.EASY2.Text = "EASY";
            this.EASY2.Click += new System.EventHandler(this.EASY2_Click);
            this.EASY2.MouseLeave += new System.EventHandler(this.EASY2_MouseLeave);
            // 
            // NORMAL2
            // 
            this.NORMAL2.AutoSize = true;
            this.NORMAL2.BackColor = System.Drawing.Color.Transparent;
            this.NORMAL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NORMAL2.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NORMAL2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NORMAL2.Location = new System.Drawing.Point(797, 260);
            this.NORMAL2.Name = "NORMAL2";
            this.NORMAL2.Size = new System.Drawing.Size(168, 56);
            this.NORMAL2.TabIndex = 6;
            this.NORMAL2.Text = "NORMAL";
            this.NORMAL2.Click += new System.EventHandler(this.NORMAL2_Click);
            this.NORMAL2.MouseLeave += new System.EventHandler(this.NORMAL2_MouseLeave);
            // 
            // HARD2
            // 
            this.HARD2.AutoSize = true;
            this.HARD2.BackColor = System.Drawing.Color.Transparent;
            this.HARD2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HARD2.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HARD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HARD2.Location = new System.Drawing.Point(822, 366);
            this.HARD2.Name = "HARD2";
            this.HARD2.Size = new System.Drawing.Size(113, 56);
            this.HARD2.TabIndex = 7;
            this.HARD2.Text = "HARD";
            this.HARD2.Click += new System.EventHandler(this.Hard2_Click);
            this.HARD2.MouseLeave += new System.EventHandler(this.HARD2_MouseLeave);
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.BackColor = System.Drawing.Color.Transparent;
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(0, 539);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(119, 48);
            this.EXIT.TabIndex = 8;
            this.EXIT.Text = "EXIT";
            this.EXIT.MouseEnter += new System.EventHandler(this.EXIT_MouseEnter);
            // 
            // EXIT2
            // 
            this.EXIT2.AutoSize = true;
            this.EXIT2.BackColor = System.Drawing.Color.Transparent;
            this.EXIT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT2.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT2.ForeColor = System.Drawing.Color.DarkRed;
            this.EXIT2.Location = new System.Drawing.Point(0, 539);
            this.EXIT2.Name = "EXIT2";
            this.EXIT2.Size = new System.Drawing.Size(119, 48);
            this.EXIT2.TabIndex = 9;
            this.EXIT2.Text = "EXIT";
            this.EXIT2.Click += new System.EventHandler(this.EXIT2_Click);
            this.EXIT2.MouseLeave += new System.EventHandler(this.EXIT2_MouseLeave);
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 585);
            this.Controls.Add(this.LVL);
            this.Controls.Add(this.EASY);
            this.Controls.Add(this.EASY2);
            this.Controls.Add(this.NORMAL);
            this.Controls.Add(this.NORMAL2);
            this.Controls.Add(this.HARD);
            this.Controls.Add(this.HARD2);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.EXIT2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory FanGame: The Witcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LVL;
        private System.Windows.Forms.Label EASY;
        private System.Windows.Forms.Label NORMAL;
        private System.Windows.Forms.Label HARD;
        private System.Windows.Forms.Label EASY2;
        private System.Windows.Forms.Label NORMAL2;
        private System.Windows.Forms.Label HARD2;
        private System.Windows.Forms.Label EXIT;
        private System.Windows.Forms.Label EXIT2;
    }
}