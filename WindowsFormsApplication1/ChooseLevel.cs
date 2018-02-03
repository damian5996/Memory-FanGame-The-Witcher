using System;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class ChooseLevel : Form
    {
        Thread Close2;
        Thread Close3;
        Thread Close4;

        public ChooseLevel()
        {
            InitializeComponent();
        }
                                        //wybor poziomu tudnosci, adekwatnie do wybranego przycisku otwiera sie okno
        #region EASY

        private void EASY_MouseEnter(object sender, EventArgs e)
        {
            EASY.Visible = false;
            EASY2.Visible = true;
        }

        private void EASY2_MouseLeave(object sender, EventArgs e)
        {
            EASY.Visible = true;
            EASY2.Visible = false;
        }

        private void EASY2_Click(object sender, EventArgs e)
        {
                this.Close();
                Close2 = new Thread(opennewform2);
                Close2.SetApartmentState(ApartmentState.STA);
                Close2.Start();
        }
        private void opennewform2()
        {
            Application.Run(new EasyGame());
        }
        #endregion

        #region NORMAL
        private void NORMAL_MouseEnter(object sender, EventArgs e)
        {
            NORMAL.Visible = false;
            NORMAL2.Visible = true;
        }

        private void NORMAL2_MouseLeave(object sender, EventArgs e)
        {
            NORMAL.Visible = true;
            NORMAL2.Visible = false;
        }
        private void NORMAL2_Click(object sender, EventArgs e)
        {
                this.Close();
                Close3 = new Thread(opennewform3);
                Close3.SetApartmentState(ApartmentState.STA);
                Close3.Start();
        }
        private void opennewform3()
        {
            Application.Run(new NormalGame());
        }
        #endregion

        #region HARD
        private void HARD_MouseEnter(object sender, EventArgs e)
        {
            HARD.Visible = false;
            HARD2.Visible = true;
        }

        private void HARD2_MouseLeave(object sender, EventArgs e)
        {
            HARD.Visible = true;
            HARD2.Visible = false;
        }
        private void Hard2_Click(object sender, EventArgs e)
        {
            this.Close();
            Close4 = new Thread(opennewform4);
            Close4.SetApartmentState(ApartmentState.STA);
            Close4.Start();
        }
        private void opennewform4()
        {
            Application.Run(new HardGame());
        }
        #endregion

        #region EXIT
        private void EXIT2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EXIT_MouseEnter(object sender, EventArgs e)
        {
            EXIT.Visible = false;
            EXIT2.Visible = true;
        }

        private void EXIT2_MouseLeave(object sender, EventArgs e)
        {
            EXIT.Visible = true;
            EXIT2.Visible = false;
        }
        #endregion

    }
}
