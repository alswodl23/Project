using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SockSockGame
{
    class GameOver
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //이미지
        PictureBox image1;

        public void Game_Over()
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new MethodInvoker(delegate ()
                {
                    form.pnlMain.Controls.Clear();
                    image1 = new PictureBox();
                    form.pnlMain.Controls.Add(image1);

                    image1.Click += Over_Click;
                    image1.MouseHover += Over_hover;
                    image1.MouseLeave += Over_leave;

                    image1.Location = new System.Drawing.Point(72, 119);
                    image1.Size = new System.Drawing.Size(808, 468);
                    image1.Image = Properties.Resources.GameOver;
                    image1.BackColor = System.Drawing.Color.Transparent;
                    image1.SizeMode = PictureBoxSizeMode.StretchImage;
                }));
            }
        }

        private void Over_hover(object sender, EventArgs e)
        {
            image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void Over_leave(object sender, EventArgs e)
        {
            image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Over_Click(object sender, EventArgs e)
        {
            form.btnHome_Click(sender, e);
        }
    }
}
