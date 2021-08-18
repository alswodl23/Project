using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace SockSockGame
{
    public partial class Form1 : Form
    {
        public void Sound()
        {
            soundCheck = true;
            int soundRand = rand.Next(0, 5);

            switch (soundRand)
            {
                case 0:
                    //Swing by Peyruis | https://soundcloud.com/peyruis
                    //Music promoted by https://www.mewpot.com
                    //CC BY 3.0 | https://creativecommons.org/licenses/by/3.0/
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.MP_Swing);
                    break;
                case 1:
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.MP_Colours);
                    break;
                case 2:
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.MP_Dusk);
                    break;
                case 3:
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.MP_Halcyon);
                    break;
                case 4:
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.MP_Vast_Chant);
                    break;
                case 5:
                    soundPlayer = new System.Media.SoundPlayer(Properties.Resources.MP_Duel_Funk_Rock);
                    break;
                default:
                    break;
            }
            soundPlayer.PlayLooping();
            soundPlayer.Play();
        }

        private void Sound_stop()
        {
            soundCheck = false;
            soundPlayer.Stop();
        }
    }
}
