namespace WindowsFormsApplication1
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.EXIT = new System.Windows.Forms.Label();
            this.EXIT2 = new System.Windows.Forms.Label();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.BackColor = System.Drawing.Color.Transparent;
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(-1, 540);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(119, 48);
            this.EXIT.TabIndex = 1;
            this.EXIT.Text = "EXIT";
            this.EXIT.MouseEnter += new System.EventHandler(this.EXIT_MouseEnter_1);
            // 
            // EXIT2
            // 
            this.EXIT2.AutoSize = true;
            this.EXIT2.BackColor = System.Drawing.Color.Transparent;
            this.EXIT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT2.Font = new System.Drawing.Font("High Tower Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT2.ForeColor = System.Drawing.Color.DarkRed;
            this.EXIT2.Location = new System.Drawing.Point(-1, 540);
            this.EXIT2.Name = "EXIT2";
            this.EXIT2.Size = new System.Drawing.Size(119, 48);
            this.EXIT2.TabIndex = 2;
            this.EXIT2.Text = "EXIT";
            this.EXIT2.Click += new System.EventHandler(this.EXIT2_Click);
            this.EXIT2.MouseLeave += new System.EventHandler(this.EXIT2_MouseLeave);
            // 
            // buttonBegin
            // 
            this.buttonBegin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBegin.Image = global::WindowsFormsApplication1.Properties.Resources.beginB;
            this.buttonBegin.Location = new System.Drawing.Point(658, 515);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBegin.Size = new System.Drawing.Size(170, 58);
            this.buttonBegin.TabIndex = 3;
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            this.buttonBegin.MouseEnter += new System.EventHandler(this.buttonBegin_MouseEnter);
            this.buttonBegin.MouseLeave += new System.EventHandler(this.buttonBegin_MouseLeave);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 585);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.EXIT2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory FanGame: The Witcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EXIT;
        private System.Windows.Forms.Label EXIT2;
        private System.Windows.Forms.Button buttonBegin;
    }
}

