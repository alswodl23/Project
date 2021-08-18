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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlNavi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //랜덤카테고리
        Random rand = new Random();

        //랜덤숫자 배열에 담아 둠
        List<int> randomNumbers = new List<int>();

        //사운드
        System.Media.SoundPlayer soundPlayer;
        bool soundCheck = false;

        //넘어가기 기능 카운트
        public int skipGame = 3;

        //ID 닉네임 저장
        public string id = null;

        //타이머
        public int counter = 0;

        //스레드
        public Thread thr;
        public Thread thrG;
        public bool thrOn = false;

        //게임오버
        GameOver go;

        //점수
        int Score_Counrt = 0;
        int Score = 0;

        //랭킹보드
        RankingBoard[] Rank = new RankingBoard[10];

       public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initplay();
            //Sound();
        }

        internal void pnlMain_Add()
        {
            pnlMain.Controls.Add(lblTimer);
            pnlMain.Controls.Add(lblTimerCount);
            pnlMain.Controls.Add(ptbHeart1);
            pnlMain.Controls.Add(ptbHeart2);
            pnlMain.Controls.Add(ptbHeart3);
            pnlMain.Controls.Add(btnNext);
        }

        internal void Visible_Game_Start()
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

        internal void Visible_Game_Stop()
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

        internal void initplay()
        {
            Visible_Game_Stop();
            pnlMain.BackgroundImage = Properties.Resources.Main_BG1;//배경화면
        }

        internal void Next_Game()
        {
            DialogResult result = MessageBox.Show("다음 게임으로 넘어갑니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (counter > 0)
                {
                    Start_Game();
                }
            }
        }

        internal void Start_Game()
        {
            int GameNumb = rand.Next(1, 4);

            while (true)
            {
                if (randomNumbers.Contains(GameNumb))
                {
                    GameNumb = rand.Next(1, 4);
                }
                else
                {
                    break;
                }
            }
            randomNumbers.Add(GameNumb);
            switch (5)
            {
                case 1:
                    GameC001 C001 = new GameC001();
                    C001.Play();
                    break;
                case 2:
                    GameC002 C002 = new GameC002();
                    C002.InitGame();
                    break;
                case 3:
                    GameC003 C003 = new GameC003();
                    C003.InitGame();
                    break;
                case 4:
                    GameL001 L001 = new GameL001();
                    L001.Game_L001();
                    break;
                case 5:
                    GameL002 L002 = new GameL002();
                    L002.Game_L002();
                    break;
                case 6:
                    GameL003 L003 = new GameL003();
                    L003.initGameL003();
                    break;
                case 7:
                    GameS001 S001 = new GameS001();
                    S001.InitGame();
                    break;
                //case 7:
                //    GameK001 K001 = new GameK001();
                //    K001.InitGameK001();
                //    break;
            }
            if (Score_Counrt != 0)
            {
                Score += Score_Counrt * 100;

                lblScore.Text = Score.ToString();
            }
            Score_Counrt++;
        }

        ///////////////////////////Form1.cs[디자인]에서 추가한 이벤트

        private void btnEnd_Click(object sender, EventArgs e)
        {
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
                id = txtID.Text;
                MessageBox.Show("게임을 시작합니다. 준비 되셨죠?");

                counter = 10;
                timer.Enabled = true;

                Start_Game();
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

        public void btnHome_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Controls.Clear();
            this.InitializeComponent();
        }

        public void btnNext_Click(object sender, EventArgs e)
        {
            if (thrOn == true)
            {
                thrOn = false;
                thrG.Abort();
            }
            if (skipGame != 0)
            {
                if (skipGame == 3)
                {
                    this.ptbHeart3.BackgroundImage = Properties.Resources.hart_BG;
                    Score_Counrt = 0;
                }
                else if (skipGame == 2)
                {
                    this.ptbHeart2.BackgroundImage = Properties.Resources.hart_BG;
                    Score_Counrt = 0;
                }
                else if (skipGame == 1)
                {
                    this.ptbHeart1.BackgroundImage = Properties.Resources.hart_BG;
                    Score_Counrt = 0;
                }

                
                pnlMain.Controls.Clear();
                pnlMain_Add();
                Visible_Game_Start();
                Next_Game();
            }

            skipGame--;

            if (skipGame == 0)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Controls.Clear();
            this.InitializeComponent();
            txtID.Text = id;
            this.btnStart.PerformClick();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if(counter <= 0)
            {
                go = new GameOver();
                thr = new Thread(new ThreadStart(go.Game_Over));

                if (thrOn == true)
                {
                    thrOn = false;
                    thrG.Abort();
                }

                timer.Stop();
                
                thr.IsBackground = true;
                thr.Start();
            }

            lblTimerCount.Text = counter.ToString();

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
