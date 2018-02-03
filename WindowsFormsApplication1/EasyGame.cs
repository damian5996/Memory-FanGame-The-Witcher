using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class EasyGame : Form
    {
        Thread Close5;
        Thread Close7;
        #region IMAGE                           
        Image bruxa = Resources.bruxa2E;
        Image ciri = Resources.ciriE;
        Image geralt = Resources.geraltE;
        Image logo = Resources.back1;
        #endregion                                      
        List<Button> Buttons = new List<Button>();
        List<int> Rand = new List<int>();
        #region VAR
        private int deletedCards = 0; 
        public int[] tab = new int[6];
        public int[] clicked = new int[2];
        private int which;
        private int counter = 0;
        private int score;
        private int count_bruxa = 60;
        private int count_ciri = 60;
        private int count_geralt = 60;
        #endregion
        public EasyGame()
        {
            #region Random
            Rand = new List<int> { 0, 0, 1, 1, 2, 2 };
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)                         //funkcja pozwalajaca na losowosc obrazkow 
            {
                int RandIndex = rnd.Next(Rand.Count);
                tab[i] = Rand[RandIndex];
                Rand.Remove(Rand[RandIndex]);
            }
        
            #endregion

            InitializeComponent();
        }
        private void EasyGame_Load(object sender, EventArgs e)
        {
            Buttons = new List<Button> { button1, button2, button3, button4, button5, button6 };
        }
        private void EasyEnd()                      // wyniki i tekst, adekwatny do uzyskanych pkt
        {
            if (deletedCards == 6)
            {
                if (score >= 150)
                {
                    if (MessageBox.Show("Your score: " + score + ". Unbelievable! You are the real master!\nDo you want to play again?", "The End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        Close();
                        this.Close();
                        Close5 = new Thread(opennewform8);
                        Close5.SetApartmentState(ApartmentState.STA);
                        Close5.Start();
                    }
                    else
                    {
                        Close();
                        this.Close();
                        Close5 = new Thread(opennewform9);
                        Close5.SetApartmentState(ApartmentState.STA);
                        Close5.Start();
                    }
                }
                if (score < 150 && score >= 100)
                {
                    if (MessageBox.Show("Your score: " + score + ". Average. Try harder!\nMaybe next time you'll reach the bigger score :)\nDo you want to play again?", "The End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        Close();
                        this.Close();
                        Close5 = new Thread(opennewform8);
                        Close5.SetApartmentState(ApartmentState.STA);
                        Close5.Start();
                    }
                    else
                    {
                        Close();
                        this.Close();
                        Close5 = new Thread(opennewform9);
                        Close5.SetApartmentState(ApartmentState.STA);
                        Close5.Start();
                    }
                }
                if (score < 100)
                {
                    if (MessageBox.Show("Your score: " + score + ". Ooops. You should train your memory!\nDo you want to play again?", "The End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        Close();
                        this.Close();
                        Close5 = new Thread(opennewform8);
                        Close5.SetApartmentState(ApartmentState.STA);
                        Close5.Start();
                    }
                    else
                    {
                        Close();
                        this.Close();
                        Close5 = new Thread(opennewform9);
                        Close5.SetApartmentState(ApartmentState.STA);
                        Close5.Start();
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
            Application.Run(new EasyGame());
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
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            WhichButton(button);
            if (counter < 2) 
            {
                if (tab[which] == 0)
                {
                    button.Image = bruxa;
                    count_bruxa -= 5;
                }
                else if (tab[which] == 1)
                {
                    button.Image = ciri;
                    count_ciri -= 5;
                }
                else if (tab[which] == 2)
                {
                    button.Image = geralt;
                    count_geralt -= 5;
                }
                clicked[counter] = tab[which];
                counter++;
            }
            else //przy trzecim kliknięciu resetuje 
            {
                reset();
                if (clicked[0] == clicked[1])//usuwa dwie takie same karty
                {
                    delete(clicked[0]);
                    deletedCards+=2; //zlicza liczbe odkrytych kart
                }
                EasyEnd();
            }
        }
        private void reset()//obraca karte na tylnia strone
        {
            foreach (var button in Buttons)
            {
                button.Image = logo;
            }
            counter = 0; //resetuje licznik
        }
        private void delete(int a) 
        {
            foreach (var button in Buttons)
            {
                WhichButton(button);
                if (tab[which] == a)
                {
                    button.Visible = false;
                }
            }
            //zliczanie punktow do wyniku
            #region count_bruxa
            if (a == 0)
            {
                score += count_bruxa;
                label1.Text = score.ToString();
            }
            #endregion
            #region count_ciri
            else if (a == 1)
            {
                score += count_ciri;
                label1.Text = score.ToString();
            }
            #endregion
            #region count_geralt
            else if (a == 2)
            {
                score += count_geralt;
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
            Close7 = new Thread(previousForm3);
            Close7.SetApartmentState(ApartmentState.STA);
            Close7.Start();
        }
        private void previousForm3()
        {
            Application.Run(new ChooseLevel());
        }
        #endregion    
    }
}