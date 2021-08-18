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
    class GameL003
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //랜덤번호 뽑기 위한 랜덤객체
        static Random rand = new Random();

        //타이틀
        Label Title = new Label();

        //게임 관련 체크
        Button btnPrev;
        Button btnNull = new Button();
        int card = 0;
        int end = 0;

        //사운드
        System.Media.SoundPlayer soundPlayer1;

        //카드 뒤집기용 버튼 8개
        Button btnCard1 = new Button();
        Button btnCard2 = new Button();
        Button btnCard3 = new Button();
        Button btnCard4 = new Button();
        Button btnCard5 = new Button();
        Button btnCard6 = new Button();
        Button btnCard7 = new Button();
        Button btnCard8 = new Button();

        internal void initGameL003()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.Night;

            Title.AutoSize = true;
            Title.BackColor = System.Drawing.Color.Transparent;
            Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Title.ForeColor = System.Drawing.Color.White;
            Title.Location = new System.Drawing.Point(311, 75);
            Title.Size = new System.Drawing.Size(339, 55);
            Title.TabIndex = 29;
            Title.Text = "동물 카드 뒤집기!";

            Bitmap[] img = { global::SockSockGame.Properties.Resources.Game2_1,
                        global::SockSockGame.Properties.Resources.Game2_2,
                        global::SockSockGame.Properties.Resources.Game2_3,
                        global::SockSockGame.Properties.Resources.Game2_4
            };

            this.btnCard1.BackColor = System.Drawing.Color.Transparent;
            this.btnCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard1.Location = new System.Drawing.Point(78, 161);
            this.btnCard1.Size = new System.Drawing.Size(179, 260);
            this.btnCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard2.BackColor = System.Drawing.Color.Transparent;
            this.btnCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard2.Location = new System.Drawing.Point(292, 161);
            this.btnCard2.Size = new System.Drawing.Size(179, 260);
            this.btnCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard3.BackColor = System.Drawing.Color.Transparent;
            this.btnCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard3.Location = new System.Drawing.Point(506, 161);
            this.btnCard3.Size = new System.Drawing.Size(179, 260);
            this.btnCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard4.BackColor = System.Drawing.Color.Transparent;
            this.btnCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard4.Location = new System.Drawing.Point(720, 161);
            this.btnCard4.Size = new System.Drawing.Size(179, 260);
            this.btnCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard5.BackColor = System.Drawing.Color.Transparent;
            this.btnCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard5.Location = new System.Drawing.Point(78, 439);
            this.btnCard5.Size = new System.Drawing.Size(179, 260);
            this.btnCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard6.BackColor = System.Drawing.Color.Transparent;
            this.btnCard6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard6.Location = new System.Drawing.Point(292, 439);
            this.btnCard6.Size = new System.Drawing.Size(179, 260);
            this.btnCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard7.BackColor = System.Drawing.Color.Transparent;
            this.btnCard7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard7.Location = new System.Drawing.Point(506, 439);
            this.btnCard7.Size = new System.Drawing.Size(179, 260);
            this.btnCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnCard8.BackColor = System.Drawing.Color.Transparent;
            this.btnCard8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard8.Location = new System.Drawing.Point(720, 439);
            this.btnCard8.Size = new System.Drawing.Size(179, 260);
            this.btnCard8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.btnNull.BackgroundImage = SockSockGame.Properties.Resources.Duduge;

            btnCard1.Click += btnCard_Click;
            btnCard2.Click += btnCard_Click;
            btnCard3.Click += btnCard_Click;
            btnCard4.Click += btnCard_Click;
            btnCard5.Click += btnCard_Click;
            btnCard6.Click += btnCard_Click;
            btnCard7.Click += btnCard_Click;
            btnCard8.Click += btnCard_Click;

            for (int i = 0; i < 2; i++)//2번 실행된다.
            {
                for (int j = 0; j < 4;)
                {
                    int r = rand.Next(0, 8);
                    switch (r)
                    {
                        case 0:
                            if (this.btnCard1.BackgroundImage == null)
                            {
                                this.btnCard1.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 1:
                            if (this.btnCard2.BackgroundImage == null)
                            {
                                this.btnCard2.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 2:
                            if (this.btnCard3.BackgroundImage == null)
                            {
                                this.btnCard3.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 3:
                            if (this.btnCard4.BackgroundImage == null)
                            {
                                this.btnCard4.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 4:
                            if (this.btnCard5.BackgroundImage == null)
                            {
                                this.btnCard5.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 5:
                            if (this.btnCard6.BackgroundImage == null)
                            {
                                this.btnCard6.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 6:
                            if (this.btnCard7.BackgroundImage == null)
                            {
                                this.btnCard7.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                        case 7:
                            if (this.btnCard8.BackgroundImage == null)
                            {
                                this.btnCard8.BackgroundImage = img[j];
                                j++;
                            }
                            break;
                    }

                }
            }

            //버튼 패널추가
            form.pnlMain.Controls.Add(btnCard1);
            form.pnlMain.Controls.Add(btnCard2);
            form.pnlMain.Controls.Add(btnCard3);
            form.pnlMain.Controls.Add(btnCard4);
            form.pnlMain.Controls.Add(btnCard5);
            form.pnlMain.Controls.Add(btnCard6);
            form.pnlMain.Controls.Add(btnCard7);
            form.pnlMain.Controls.Add(btnCard8);
            form.pnlMain.Controls.Add(Title);

        }

        private void check()
        {
            form.pnlMain.Controls.Remove(btnCard1);
            form.pnlMain.Controls.Remove(btnCard2);
            form.pnlMain.Controls.Remove(btnCard3);
            form.pnlMain.Controls.Remove(btnCard4);
            form.pnlMain.Controls.Remove(btnCard5);
            form.pnlMain.Controls.Remove(btnCard6);
            form.pnlMain.Controls.Remove(btnCard7);
            form.pnlMain.Controls.Remove(btnCard8);
            form.pnlMain.Controls.Remove(Title);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            soundPlayer1 = new System.Media.SoundPlayer(Properties.Resources.Bbong);
            soundPlayer1.Stop();
            soundPlayer1.Play();

            Button buffer = (Button)sender;

            buffer.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            buffer.FlatAppearance.BorderSize = 5;
            card++;


            if (card == 2)
            {
                card = 0;

                btnCard1.FlatAppearance.BorderSize = 0;
                btnCard2.FlatAppearance.BorderSize = 0;
                btnCard3.FlatAppearance.BorderSize = 0;
                btnCard4.FlatAppearance.BorderSize = 0;
                btnCard5.FlatAppearance.BorderSize = 0;
                btnCard6.FlatAppearance.BorderSize = 0;
                btnCard7.FlatAppearance.BorderSize = 0;
                btnCard8.FlatAppearance.BorderSize = 0;

                if (buffer.BackgroundImage == btnPrev.BackgroundImage)
                {
                    buffer.BackgroundImage = SockSockGame.Properties.Resources.CardBack_G;
                    btnPrev.BackgroundImage = SockSockGame.Properties.Resources.CardBack_G;
                    buffer.Click -= btnCard_Click;
                    btnPrev.Click -= btnCard_Click;
                    end++;
                }
            }

            if (end == 4)
            {
                check();
                form.Next_Game();
            }

            btnPrev = buffer;
        }

    }
}
