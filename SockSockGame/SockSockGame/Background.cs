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

namespace SockSockGame
{
    public partial class Form1 : Form
    {
        //배경 클레스
        public void BG_Main()
        {
            pnlMain.BackgroundImage = Properties.Resources.Main_BG1;//배경화면
        }

        public void BG1()
        {
            pnlMain.BackgroundImage = Properties.Resources.ground;//배경화면
        }
    }
}
