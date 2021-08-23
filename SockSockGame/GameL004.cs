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
    class GameL004
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //랜덤번호 뽑기 위한 랜덤객체
        static Random rand = new Random();

        //타이틀
        Label Title = new Label();

        //랜덤숫자 배열에 담아 둠
        List<int> randomNumbers1;
        List<int> randomNumbers2;

        //게임 관련 체크
        int clear;

        //사운드
        System.Media.SoundPlayer soundPlayer1;

        //정답 예시용 박스
        Button btnBogi = new Button();

        //객관식 정답용 버튼
        Button btnCard1 = new Button();
        Button btnCard2 = new Button();
        Button btnCard3 = new Button();
        Button btnCard4 = new Button();

        private void play()
        {
            Bitmap[] img = { global::SockSockGame.Properties.Resources.Game2_1,
                        global::SockSockGame.Properties.Resources.Game2_2,
                        global::SockSockGame.Properties.Resources.Game2_3,
                        global::SockSockGame.Properties.Resources.Game2_4,
                        global::SockSockGame.Properties.Resources.Game2_5,
                        global::SockSockGame.Properties.Resources.Game2_6,
                        global::SockSockGame.Properties.Resources.Game2_7,
                        global::SockSockGame.Properties.Resources.Game2_8,
                        global::SockSockGame.Properties.Resources.Game2_9,
                        global::SockSockGame.Properties.Resources.Game2_10,
                        global::SockSockGame.Properties.Resources.Game2_11,
                        global::SockSockGame.Properties.Resources.Game2_12
            };

            //렌덤 담아두는 곳
            randomNumbers1 = new List<int>();
            randomNumbers2 = new List<int>();

            for (int j = 0; j < 4; j++)
            {
                int r = rand.Next(0, 4);
                int i = rand.Next(0, 12);

                while (true)
                {
                    if (randomNumbers1.Contains(r))
                    {
                        r = rand.Next(0, 4);
                    }
                    else
                    {
                        break;
                    }
                }
                randomNumbers1.Add(r);

                while (true)
                {
                    if (randomNumbers2.Contains(i))
                    {
                        i = rand.Next(0, 12);
                    }
                    else
                    {
                        break;
                    }
                }
                randomNumbers2.Add(i);

                switch (r)
                {
                    case 0:
                        this.btnCard1.BackgroundImage = img[i];
                        break;
                    case 1:
                        this.btnCard2.BackgroundImage = img[i];
                        break;
                    case 2:
                        this.btnCard3.BackgroundImage = img[i];
                        break;
                    case 3:
                        this.btnCard4.BackgroundImage = img[i];
                        break;
                }
                if (this.btnBogi.BackgroundImage == null)
                {
                    this.btnBogi.BackgroundImage = img[i];
                }
            }
        }

        private void clean()
        {
            this.btnCard1.BackgroundImage = null;
            this.btnCard2.BackgroundImage = null;
            this.btnCard3.BackgroundImage = null;
            this.btnCard4.BackgroundImage = null;
            this.btnBogi.BackgroundImage = null;
        }

        internal void initGameL004()
        {
            clear = 0;
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.Night;

            Title.AutoSize = true;
            Title.BackColor = System.Drawing.Color.Transparent;
            Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Title.ForeColor = System.Drawing.Color.White;
            Title.Location = new System.Drawing.Point(339, 92);
            Title.Size = new System.Drawing.Size(56, 31);
            Title.Text = "보기";

            this.btnBogi.BackColor = System.Drawing.Color.Transparent;
            this.btnBogi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBogi.Location = new System.Drawing.Point(401, 92);
            this.btnBogi.Size = new System.Drawing.Size(192, 284);
            this.btnBogi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBogi.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnBogi.FlatAppearance.BorderSize = 10;

            this.btnCard1.BackColor = System.Drawing.Color.Transparent;
            this.btnCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard1.Location = new System.Drawing.Point(19, 392);
            this.btnCard1.Size = new System.Drawing.Size(231, 343);
            this.btnCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard2.BackColor = System.Drawing.Color.Transparent;
            this.btnCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard2.Location = new System.Drawing.Point(261, 392);
            this.btnCard2.Size = new System.Drawing.Size(231, 343);
            this.btnCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard3.BackColor = System.Drawing.Color.Transparent;
            this.btnCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard3.Location = new System.Drawing.Point(503, 392);
            this.btnCard3.Size = new System.Drawing.Size(231, 343);
            this.btnCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard4.BackColor = System.Drawing.Color.Transparent;
            this.btnCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard4.Location = new System.Drawing.Point(745, 392);
            this.btnCard4.Size = new System.Drawing.Size(231, 343);
            this.btnCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnCard1.Click += btnCard_Click;
            btnCard2.Click += btnCard_Click;
            btnCard3.Click += btnCard_Click;
            btnCard4.Click += btnCard_Click;

            //버튼 패널추가
            form.pnlMain.Controls.Add(btnBogi);
            form.pnlMain.Controls.Add(btnCard1);
            form.pnlMain.Controls.Add(btnCard2);
            form.pnlMain.Controls.Add(btnCard3);
            form.pnlMain.Controls.Add(btnCard4);
            form.pnlMain.Controls.Add(Title);

            play();
        }

        private void check()
        {
            form.pnlMain.Controls.Remove(btnCard1);
            form.pnlMain.Controls.Remove(btnCard2);
            form.pnlMain.Controls.Remove(btnCard3);
            form.pnlMain.Controls.Remove(btnCard4);
            form.pnlMain.Controls.Remove(btnBogi);
            form.pnlMain.Controls.Remove(Title);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Button buffer = (Button)sender;

            if (clear >= 5)
            {
                check();
                form.Next_Game();
            }
            else
            {
                if (btnBogi.BackgroundImage == buffer.BackgroundImage)
                {
                    soundPlayer1 = new System.Media.SoundPlayer(Properties.Resources.Lanswer);
                    soundPlayer1.Stop();
                    soundPlayer1.Play();

                    clear++;

                    clean();
                    play();
                }
                else
                {
                    soundPlayer1 = new System.Media.SoundPlayer(Properties.Resources.Lwrong);
                    soundPlayer1.Stop();
                    soundPlayer1.Play();
                }
            }
        }
    }
}
