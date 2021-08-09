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
using System.Windows.Media;//참조 추가에서 PresentationCore.dll 추가해야함.

namespace SockSockGame
{
    public partial class Form1 : Form
    {
        //랜덤카테고리
        Random rand = new Random();

        //이미지박스 카테고리(주로 미니게임내에 사용되는 객체들에 이용)
        PictureBox Image1 = new PictureBox();

        //게임 클리어 조건구역
        int clear = 0;

        //Thread 구역
        Thread thr1;

        //사운드
        System.Media.SoundPlayer soundPlayer;
        bool soundCheck = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //미니게임에 사용되는 이미지들은 미리미리 패널에 등록해놔야 오류가 안생김.
            pnlMain.Controls.Add(Image1);
            initplay();
            Sound();
        }

        private void Visible_Game_Start()
        {
            lblTimer.Visible = true;
            lblTimerCount.Visible = true;
            btnNext.Visible = true;
            ptbHeart1.Visible = true;
            ptbHeart2.Visible = true;
            ptbHeart3.Visible = true;
            txtID.Visible = false;
            btnStart.Visible = false;
            btnHowToPlay.Visible = false;
            pnlHowToPlay.Visible = false;
        }

        private void Visible_Game_Stop()
        {
            lblTimer.Visible = false;
            lblTimerCount.Visible = false;
            btnNext.Visible = false;
            ptbHeart1.Visible = false;
            ptbHeart2.Visible = false;
            ptbHeart3.Visible = false;
            txtID.Visible = true;
            btnStart.Visible = true;
            btnHowToPlay.Visible = true;
        }

        private void initplay()
        {
            Visible_Game_Stop();
            pnlMain.BackgroundImage = Properties.Resources.Main_BG1;//배경화면
        }

        private void BG_Main()
        {
            pnlMain.BackgroundImage = Properties.Resources.Main_BG1;//배경화면
        }

        private void BG1()
        {
            pnlMain.BackgroundImage = Properties.Resources.Night;//배경화면
        }

        private void Sound()
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


        private void stop()
        {
            BG_Main();
            Visible_Game_Stop();
        }

        private void play()
        {
            clear = 2;
            int object_x = rand.Next(55, 900);
            int object_y = rand.Next(160, 580);

            Image1.Click += Image_Click;

            while (true)
            {
                if (clear <= 0)
                {
                    break;
                }
                else if(clear > 0)
                {
                    Thread.Sleep(2000);
                    object_x = rand.Next(55, 900);
                    object_y = rand.Next(160, 580);

                    this.Invoke(new Action(delegate ()
                    {
                        Image1.Location = new Point(object_x, object_y);
                    }));
                }

            }

            //종료구간

            this.Invoke(new Action(delegate ()
            {
                Image1.Visible = false;
                stop();
            }));
        }

        private void first_Game()
        {
            
            thr1 = new Thread(new ThreadStart(play));

            BG1();
            Visible_Game_Start();

            Image1.Visible = true;
            Image1.Location = new System.Drawing.Point(522, 100);
            Image1.Size = new System.Drawing.Size(180, 100);
            //Image1.Width = 180; //위의 Image1 Size 적용하는 다른 방법
            //Image1.Height = 180;
            Image1.BackColor = System.Drawing.Color.Transparent;
            Image1.Image = Properties.Resources.Duduge;
            Image1.SizeMode = PictureBoxSizeMode.StretchImage;

            thr1.Start();
        }

        ///////////////////////////Form1.cs에서 임의로 추가한 이벤트

        private void Image_Click(object sender, EventArgs e)
        {
            int object_x = 0;
            int object_y = 0;

            object_x = rand.Next(55, 900);
            object_y = rand.Next(160, 580);

            Image1.Location = new Point(object_x, object_y);

            clear--;
        }


        ///////////////////////////Form1.cs[디자인]에서 추가한 이벤트

        private void btnEnd_Click(object sender, EventArgs e)
        {
            thr1.Abort();
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtID.Text == "이름을 입력해주세요")
            {
                MessageBox.Show("닉네임을 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtID.Text.Length > 10)
            {
                MessageBox.Show("닉네임은 10자 이하로 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("게임을 시작합니다. 준비 되셨죠?");
                first_Game();
            }
        }

        private void txtID_MouseClick(object sender, MouseEventArgs e)
        {
            // txtID 초기값을 빈 값으로 변경
            txtID.Text = "";
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            pnlHowToPlay.Visible = true;
        }

        private void btnHowToOk_Click(object sender, EventArgs e)
        {
            pnlHowToPlay.Visible = false;
        }

        private void ptbSound_Click(object sender, EventArgs e)
        {
            if (soundCheck)
            {
                Sound_stop();
            }
            else
            {
                Sound();
            }
        }
    }
}
