using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class NormalGame : Form
    {
        Thread Close9;
        Thread Close6;
        #region IMAGE
        Image caranthir = Resources.caranthirN;
        Image geralt_ciri = Resources.geralt_ciriN;
        Image jaskier = Resources.jaskierN;
        Image eskel = Resources.EskelN;
        Image keira = Resources.keiraN;
        Image triss2 = Resources.triss2N;
        Image triss = Resources.trissN;
        Image wight = Resources.wightN;
        Image yen = Resources.yenN;
        Image logo = Resources.backN;
        #endregion

        List<Button> Buttons = new List<Button>();
        List<int> Rand = new List<int>();
        #region VAR
        private int deletedCards = 0;
        public int[] tab = new int[18];
        public int[] clicked = new int[2];
        private int counter = 0;
        private int score;
        private int count_geralt_ciri = 60;
        private int count_jaskier = 60;
        private int count_eskel = 60;
        private int count_keira = 60;
        private int count_triss2 = 60;
        private int count_triss = 60;
        private int count_wight = 60;
        private int count_yen = 60;
        private int count_caranthir = 60;
        private int which;
        #endregion

        public NormalGame()
        {
            #region Random
            Rand = new List<int> { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
            Random rnd = new Random();
            
            for(int i =0; i < 18; i++)
            {
                int RandIndex = rnd.Next(Rand.Count);
                tab[i] = Rand[RandIndex];
                Rand.Remove(Rand[RandIndex]);
            }
            #endregion

            InitializeComponent();
        }
        private void WhichButton(Button box)
        {
            if (box == button1)
                which = 0;
            else if (box == button2)
                which = 1;
            else if (box == button3)
                which = 2;
            else if (box == button4)
                which = 3;
            else if (box == button5)
                which = 4;
            else if (box == button6)
                which = 5;
            else if (box == button7)
                which = 6;
            else if (box == button8)
                which = 7;
            else if (box == button9)
                which = 8;
            else if (box == button10)
                which = 9;
            else if (box == button11)
                which = 10;
            else if (box == button12)
                which = 11;
            else if (box == button13)
                which = 12;
            else if (box == button14)
                which = 13;
            else if (box == button15)
                which = 14;
            else if (box == button16)
                which = 15;
            else if (box == button17)
                which = 16;
            else if (box == button18)
                which = 17;
        }
        private void NormalGame_Load(object sender, EventArgs e)
        {
            Buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18 };
        }
        private void EasyEnd()
        {
            if (deletedCards == 18)
            {
                if (score >= 410)
                {
                    if (MessageBox.Show("Your score: " + score + ". Unbelievable! You are the real master!\nDo you want to play again?", "The End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        Close();
                        this.Close();
                        Close9 = new Thread(opennewform8);
                        Close9.SetApartmentState(ApartmentState.STA);
                        Close9.Start();
                    }
                    else
                    {
                        Close();
                        this.Close();
                        Close9 = new Thread(opennewform9);
                        Close9.SetApartmentState(ApartmentState.STA);
                        Close9.Start();
                    }
                }
                if (score < 410 && score >= 350)
                {
                    if (MessageBox.Show("Your score: " + score + ". Average. Try harder!\nMaybe next time you'll reach the bigger score :)\nDo you want to play again?", "The End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        Close();
                        this.Close();
                        Close9 = new Thread(opennewform8);
                        Close9.SetApartmentState(ApartmentState.STA);
                        Close9.Start();
                    }
                    else
                    {
                        Close();
                        this.Close();
                        Close9 = new Thread(opennewform9);
                        Close9.SetApartmentState(ApartmentState.STA);
                        Close9.Start();
                    }
                }
                if (score < 350)
                {
                    if (MessageBox.Show("Your score: " + score + ". Ooops. You should train your memory!\nDo you want to play again?", "The End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        Close();
                        this.Close();
                        Close9 = new Thread(opennewform8);
                        Close9.SetApartmentState(ApartmentState.STA);
                        Close9.Start();
                    }
                    else
                    {
                        Close();
                        this.Close();
                        Close9 = new Thread(opennewform9);
                        Close9.SetApartmentState(ApartmentState.STA);
                        Close9.Start();
                    }
                }
            }
        }
        private void opennewform8()
        {
            Application.Run(new ChooseLevel());
        }
        private void opennewform9()
        {
            Application.Run(new NormalGame());
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            WhichButton(button);
            if (counter < 2)
            {
                if (tab[which] == 0)
                {
                    button.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                else if (tab[which] == 1)
                {
                    button.Image = jaskier;
                    count_jaskier -= 5;
                }
                else if (tab[which] == 2)
                {
                    button.Image = eskel;
                    count_eskel -= 5;
                }
                else if (tab[which] == 3)
                {
                    button.Image = keira;
                    count_keira -= 5;
                }
                else if (tab[which] == 4)
                {
                    button.Image = triss2;
                    count_triss2 -= 5;
                }
                else if (tab[which] == 5)
                {
                    button.Image = triss;
                    count_triss -= 5;
                }
                else if (tab[which] == 6)
                {
                    button.Image = wight;
                    count_wight -= 5;
                }
                else if (tab[which] == 7)
                {
                    button.Image = yen;
                    count_yen -= 5;
                }
                else if (tab[which] == 8)
                {
                    button.Image = caranthir;
                    count_caranthir -= 5;
                }
                clicked[counter] = tab[which];
                counter++;
            }
            else
            {
                reset();
                if (clicked[0] == clicked[1])
                {
                    delete(clicked[0]);
                    deletedCards += 2;
                }
                EasyEnd();
            }
        }
        private void reset()
        {
            foreach (var button in Buttons)
            {
                button.Image = logo;
            }
            counter = 0;
        }
        private void delete(int a)
        {
            #region delete
            foreach (var button in Buttons)
            {
                WhichButton(button);
                if (tab[which] == a)
                {
                    button.Visible = false;
                }
            }
            #endregion
            #region counting score

            if (a == 0)
            {
                score += count_geralt_ciri;
                label1.Text = score.ToString();
            }
            else if (a == 1)
            {
                score += count_jaskier;
                label1.Text = score.ToString();
            }
            else if (a == 2)
            {
                score += count_eskel;
                label1.Text = score.ToString();
            }
            else if (a == 3)
            {
                score += count_keira;
                label1.Text = score.ToString();
            }
            else if (a == 4)
            {
                score += count_triss2;
                label1.Text = score.ToString();
            }
            else if (a == 5)
            {
                score += count_triss;
                label1.Text = score.ToString();
            }
            else if (a == 6)
            {
                score += count_wight;
                label1.Text = score.ToString();
            }
            else if (a == 7)
            {
                score += count_yen;
                label1.Text = score.ToString();
            }
            else if (a == 8)
            {
                score += count_yen;
                label1.Text = score.ToString();
            }
            #endregion
        }
        #region BACK
        private void BACK_MouseEnter(object sender, EventArgs e)
        {
            BACK.Visible = false;
            BACK2.Visible = true;
        }

        private void BACK2_MouseLeave(object sender, EventArgs e)
        {
            BACK.Visible = true;
            BACK2.Visible = false;
        }

        private void BACK2_Click(object sender, EventArgs e)
        {
            this.Close();
            Close6 = new Thread(previousForm2);
            Close6.SetApartmentState(ApartmentState.STA);
            Close6.Start();
        }
        private void previousForm2()
        {
            Application.Run(new ChooseLevel());
        }
        #endregion
    }
}
