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
    class GameL002
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //랜덤번호 뽑기 위한 랜덤객체
        static Random rand = new Random();

        //이미지박스 카테고리(주로 미니게임내에 사용되는 객체들에 이용)
        public PictureBox Image1 = new PictureBox();

        //Lable 게임 제목 
        public Label lblGameName = new Label();
        public Label lblGameName1 = new Label();

        int clear = 0;

        private void play()
        {
            while (true)
            {
                Thread.Sleep(700);
                int i = rand.Next(6);
                if (form.InvokeRequired)
                {
                    form.Invoke(new MethodInvoker(delegate ()
                    {
                        switch (i)
                        {
                            case 0:
                                Image1.Location = new Point(15, 231);
                                break;
                            case 1:
                                Image1.Location = new Point(336, 231);
                                break;
                            case 2:
                                Image1.Location = new Point(658, 231);
                                break;
                            case 3:
                                Image1.Location = new Point(15, 477);
                                break;
                            case 4:
                                Image1.Location = new Point(336, 477);
                                break;
                            case 5:
                                Image1.Location = new Point(336, 477);
                                break;
                        }
                    }));
                }
            }
        }

        public void Game_L002()
        {
            form.thr = new Thread(new ThreadStart(play));

            //초반 화면 정리 및 배치
            form.Visible_Game_Start();
            form.pnlMain.Controls.Add(lblGameName);
            form.pnlMain.Controls.Add(lblGameName1);
            form.pnlMain.Controls.Add(Image1);
            form.BG1();

            lblGameName.Visible = true;
            lblGameName.BackColor = System.Drawing.Color.Transparent;
            lblGameName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblGameName.Text = "두더지 잡기";
            lblGameName.Location = new Point(190, 124);
            lblGameName.Size = new System.Drawing.Size(610, 101);
            lblGameName.ForeColor = System.Drawing.Color.Cyan;
            lblGameName.Font = new System.Drawing.Font("휴먼둥근헤드라인", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

            lblGameName1.Visible = true;
            lblGameName1.BackColor = System.Drawing.Color.Transparent;
            lblGameName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblGameName1.Text = "안";
            lblGameName1.Location = new Point(504, 88);
            lblGameName1.Size = new System.Drawing.Size(54, 39);
            lblGameName1.ForeColor = System.Drawing.Color.Red;
            lblGameName1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

            Image1.Location = new System.Drawing.Point(15, 231);
            Image1.Size = new System.Drawing.Size(301, 230);
            Image1.Image = Properties.Resources.Duduge_Out2;
            Image1.BackColor = System.Drawing.Color.Transparent;
            Image1.SizeMode = PictureBoxSizeMode.StretchImage;

            clear = 1;
            Image1.Click += Image_Click;

            form.thr.IsBackground = true;
            form.thr.Start();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            clear--;

            if (clear == 0)
            {
                //종료구간
                Image1.Visible = false;
                lblGameName.Visible = false;
                lblGameName1.Visible = false;
                form.initplay();
            }
            else
            {
                int i = rand.Next(6);
                switch (i)
                {
                    case 0:
                        Image1.Location = new Point(15, 231);
                        break;
                    case 1:
                        Image1.Location = new Point(336, 231);
                        break;
                    case 2:
                        Image1.Location = new Point(658, 231);
                        break;
                    case 3:
                        Image1.Location = new Point(15, 477);
                        break;
                    case 4:
                        Image1.Location = new Point(336, 477);
                        break;
                    case 5:
                        Image1.Location = new Point(336, 477);
                        break;
                }
            }

        }
    }
}
