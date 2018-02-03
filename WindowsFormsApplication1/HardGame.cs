using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsFormsApplication1.Properties;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class HardGame : Form
    {
        Thread Close5;
        Thread Close9;
        #region IMAGE
        Image logo = Resources.backH;
        Image caranthir = Resources.caranthirH;
        Image geralt_ciri = Resources.geralt_ciriH;
        Image jaskier = Resources.jaskierH;
        Image eskel = Resources.EskelH;
        Image keira = Resources.keiraH;
        Image triss2 = Resources.triss2H;
        Image triss = Resources.trissH;
        Image wight = Resources.wightH;
        Image yen = Resources.yenH;
        Image zoltan = Resources.zoltanH;
        Image bruxa = Resources.bruxa2H;
        Image ciri = Resources.ciriH;
        Image geralt = Resources.geraltH;
        Image eredin = Resources.eredinH;
        #endregion
        
        List<Button> Buttons = new List<Button>();
        List<int> Rand = new List<int>();

        #region VAR
        private int deletedCards = 0;
        public int[] tab = new int[28];
        public int[] clicked = new int[2];
        private int counter = 0;
        private int score;
        private int count_caranthir = 60;
        private int count_geralt_ciri = 60;
        private int count_jaskier = 60;
        private int count_eskel = 60;
        private int count_keira = 60;
        private int count_triss2 = 60;
        private int count_triss = 60;
        private int count_wight = 60;
        private int count_yen = 60;
        private int count_zoltan = 60;
        private int count_bruxa = 60;
        private int count_ciri = 60;
        private int count_geralt = 60;
        private int count_eredin = 60;
        private int which;
        #endregion

        public HardGame()
        {
            #region Random
            Rand = new List<int> { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13 };
            Random rnd = new Random();

            for (int i = 0; i < 28; i++)
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
            else if (box == button19)
                which = 18;
            else if (box == button20)
                which = 19;
            else if (box == button21)
                which = 20;
            else if (box == button22)
                which = 21;
            else if (box == button23)
                which = 22;
            else if (box == button24)
                which = 23;
            else if (box == button25)
                which = 24;
            else if (box == button26)
                which = 25;
            else if (box == button27)
                which = 26;
            else if (box == button28)
                which = 27;
        }
        private void HardGame_Load(object sender, EventArgs e)
        {
            Buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28 };
        }
        private void EasyEnd()
        {
            if (deletedCards == 28)
            {
                if (score >= 550)
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
                if (score < 550 && score >= 470)
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
                if (score < 470)
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
            Application.Run(new HardGame());
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
                else if (tab[which] == 9)
                {
                    button.Image = zoltan;
                    count_zoltan -= 5;
                }
                else if (tab[which] == 10)
                {
                    button.Image = bruxa;
                    count_bruxa -= 5;
                }
                else if (tab[which] == 11)
                {
                    button.Image = ciri;
                    count_ciri -= 5;
                }
                else if (tab[which] == 12)
                {
                    button.Image = geralt;
                    count_geralt -= 5;
                }
                else if (tab[which] == 13)
                {
                    button.Image = eredin;
                    count_eredin -= 5;
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
                    deletedCards+=2;
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
            if (tab[0] == a)
            {
                button1.Visible = false;
            }
            if (tab[1] == a)
            {
                button2.Visible = false;
            }
            if (tab[2] == a)
            {
                button3.Visible = false;
            }
            if (tab[3] == a)
            {
                button4.Visible = false;
            }
            if (tab[4] == a)
            {
                button5.Visible = false;
            }
            if (tab[5] == a)
            {
                button6.Visible = false;
            }
            if (tab[6] == a)
            {
                button7.Visible = false;
            }
            if (tab[7] == a)
            {
                button8.Visible = false;
            }
            if (tab[8] == a)
            {
                button9.Visible = false;
            }
            if (tab[9] == a)
            {
                button10.Visible = false;
            }
            if (tab[10] == a)
            {
                button11.Visible = false;
            }
            if (tab[11] == a)
            {
                button12.Visible = false;
            }
            if (tab[12] == a)
            {
                button13.Visible = false;
            }
            if (tab[13] == a)
            {
                button14.Visible = false;
            }
            if (tab[14] == a)
            {
                button15.Visible = false;
            }
            if (tab[15] == a)
            {
                button16.Visible = false;
            }
            if (tab[16] == a)
            {
                button17.Visible = false;
            }
            if (tab[17] == a)
            {
                button18.Visible = false;
            }
            if (tab[18] == a)
            {
                button19.Visible = false;
            }
            if (tab[19] == a)
            {
                button20.Visible = false;
            }
            if (tab[20] == a)
            {
                button21.Visible = false;
            }
            if (tab[21] == a)
            {
                button22.Visible = false;
            }
            if (tab[22] == a)
            {
                button23.Visible = false;
            }
            if (tab[23] == a)
            {
                button24.Visible = false;
            }
            if (tab[24] == a)
            {
                button25.Visible = false;
            }
            if (tab[25] == a)
            {
                button26.Visible = false;
            }
            if (tab[26] == a)
            {
                button27.Visible = false;
            }
            if (tab[27] == a)
            {
                button28.Visible = false;
            }
            #endregion
            #region counting score

            if (a == 0)
            {
                score += count_geralt_ciri;
                label1.Text = score.ToString();
            }
            if (a == 1)
            {
                score += count_jaskier;
                label1.Text = score.ToString();
            }
            if (a == 2)
            {
                score += count_eskel;
                label1.Text = score.ToString();
            }
            if (a == 3)
            {
                score += count_keira;
                label1.Text = score.ToString();
            }
            if (a == 4)
            {
                score += count_triss2;
                label1.Text = score.ToString();
            }
            if (a == 5)
            {
                score += count_triss;
                label1.Text = score.ToString();
            }
            if (a == 6)
            {
                score += count_wight;
                label1.Text = score.ToString();
            }
            if (a == 7)
            {
                score += count_yen;
                label1.Text = score.ToString();
            }
            if (a == 8)
            {
                score += count_caranthir;
                label1.Text = score.ToString();
            }
            if (a == 9)
            {
                score += count_zoltan;
                label1.Text = score.ToString();
            }
            if (a == 10)
            {
                score += count_bruxa;
                label1.Text = score.ToString();
            }
            if (a == 11)
            {
                score += count_ciri;
                label1.Text = score.ToString();
            }
            if (a == 12)
            {
                score += count_geralt;
                label1.Text = score.ToString();
            }
            if (a == 13)
            {
                score += count_eredin;
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
            Close5 = new Thread(previousForm);
            Close5.SetApartmentState(ApartmentState.STA);
            Close5.Start();
        }
        private void previousForm()
        {
            Application.Run(new ChooseLevel());
        }
        #endregion
    }
}
