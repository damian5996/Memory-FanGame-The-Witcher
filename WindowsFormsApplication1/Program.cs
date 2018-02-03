using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void playSound()
        {
            SoundPlayer sound = new SoundPlayer(@"Lullaby.wav");
            sound.PlayLooping();
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            playSound();
            Application.Run(new Start());
        }
    }
}
