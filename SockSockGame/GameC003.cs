using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SockSockGame
{
    class GameC003
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //랜덤번호 뽑기 위한 랜덤객체
        static Random rand = new Random();

        //사용자 선택 버튼 패널
        Panel UserChoice = new Panel();
        Panel GameResult = new Panel();

        PictureBox computerResult = new PictureBox();
        PictureBox userResult = new PictureBox();
        Label lblResult = new Label();

        //결과값 비교용 변수
        int computerChoice = 0;
        int userChoice = 0;

        //기본 설정 및 control 생성
        internal void InitGame()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.rsp;

            //게임 결과 올라갈 패널
            GameResult.Size = new Size(540, 471);
            GameResult.Location = new Point(33, 130);
            GameResult.BackColor = Color.BurlyWood;

            //결과패널에 올라갈 레이블 및 픽쳐박스
            Label computer = new Label();
            computer.AutoSize = true;
            computer.Font = new Font("맑은고딕", 20, FontStyle.Bold);
            computer.Location = new Point(31, 42);
            computer.Text = "상대방";

            Label userID = new Label();
            userID.AutoSize = true;
            userID.Font = new Font("맑은고딕", 20, FontStyle.Bold);
            userID.Location = new Point(31, 244);
            userID.Text = form.id;

            
            lblResult.Size = new Size(229, 48);
            lblResult.Location = new Point(287, 219);
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Font = new Font("맑은고딕", 30, FontStyle.Bold);
            lblResult.Text = "버튼 선택→";

            //컴퓨터결과 속성
            computerResult.Size = new Size(187, 157);
            computerResult.Location = new Point(45, 78);
            computerResult.BackgroundImageLayout = ImageLayout.Stretch;

            //유저 결과 속성
            userResult.Size = new Size(187, 157);
            userResult.Location = new Point(45, 280);
            userResult.BackgroundImageLayout = ImageLayout.Stretch;

            //결과패널에 등록
            GameResult.Controls.Add(computer);
            GameResult.Controls.Add(userID);
            GameResult.Controls.Add(computerResult);
            GameResult.Controls.Add(userResult);
            GameResult.Controls.Add(lblResult);

            //버튼 올라갈 패널 설정
            UserChoice.Size = new Size(233, 551);
            UserChoice.Location = new Point(740, 71);
            UserChoice.BackColor = Color.Transparent;

            //버튼 설정
            Button Rock = new Button();
            Rock.Size = new Size(176, 133);
            Rock.Location = new Point(29, 54);
            Rock.BackColor = Color.Transparent;
            Rock.BackgroundImage = Properties.Resources.rock;
            Rock.BackgroundImageLayout = ImageLayout.Stretch;
            Rock.FlatStyle = FlatStyle.Flat;
            Rock.FlatAppearance.BorderSize = 0;
            Rock.Click += Rock_Click;

            Button Scissor = new Button();
            Scissor.Size = new Size(176, 155);
            Scissor.Location = new Point(29, 210);
            Scissor.BackColor = Color.Transparent;
            Scissor.BackgroundImage = Properties.Resources.scissor;
            Scissor.BackgroundImageLayout = ImageLayout.Stretch;
            Scissor.FlatStyle = FlatStyle.Flat;
            Scissor.FlatAppearance.BorderSize = 0;
            Scissor.Click += Scissor_Click;

            Button Paper = new Button();
            Paper.Size = new Size(176, 133);
            Paper.Location = new Point(29, 397);
            Paper.BackColor = Color.Transparent;
            Paper.BackgroundImage = Properties.Resources.paper;
            Paper.BackgroundImageLayout = ImageLayout.Stretch;
            Paper.FlatStyle = FlatStyle.Flat;
            Paper.FlatAppearance.BorderSize = 0;
            Paper.Click += Paper_Click;

            //버튼 패널에 등록 및 패널 화면에 등록
            UserChoice.Controls.Add(Rock);
            UserChoice.Controls.Add(Scissor);
            UserChoice.Controls.Add(Paper);

            form.pnlMain.Controls.Add(UserChoice);
            form.pnlMain.Controls.Add(GameResult);

        }

        private void Paper_Click(object sender, EventArgs e)
        {
            userResult.BackgroundImage = Properties.Resources.paperResult;
            userChoice = 3;
            showCompResult();
            Check();
        }

        private void Scissor_Click(object sender, EventArgs e)
        {
            userResult.BackgroundImage = Properties.Resources.scissorResult;
            userChoice = 2;
            showCompResult();
            Check();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            userResult.BackgroundImage = Properties.Resources.rockResult;
            userChoice = 1;
            showCompResult();
            Check();
        }

        internal void showCompResult()
        {
            computerChoice = rand.Next(1, 4);
            
            switch(computerChoice)
            {
                case 1:
                    computerResult.BackgroundImage = Properties.Resources.rockResult;
                    break;
                case 2:
                    computerResult.BackgroundImage = Properties.Resources.scissorResult;
                    break;
                case 3:
                    computerResult.BackgroundImage = Properties.Resources.paperResult;
                    break;
            }
        }

        internal async void Check()
        {
            if(computerChoice == userChoice)
            {
                //비김 처리는 한번에!
                lblResult.Text = "Draw ~";
            }
            else
            {
                if (userChoice == 1)
                {
                    //유저가 낸게 바위
                    if (computerChoice == 2)
                    {
                        //컴퓨터는 가위
                        lblResult.Text = "You Win!";
                    }
                    else if(computerChoice == 3)
                    {
                        //컴퓨터는 보
                        lblResult.Text = "You lose..";
                    }
                }
                else if (userChoice == 2)
                {
                    //유저가 낸게 가위
                    if(computerChoice == 1)
                    {
                        //컴퓨터는 바위
                        lblResult.Text = "You lose..";
                    }
                    else if (computerChoice == 3)
                    {
                        //컴퓨터는 보
                        lblResult.Text = "You Win!";
                    }
                }
                else if (userChoice == 3)
                {
                    //유저가 낸게 보
                    if(computerChoice == 1)
                    {
                        //컴퓨터는 바위
                        lblResult.Text = "You Win!";
                    }
                    else if (computerChoice == 2)
                    {
                        //컴퓨터는 가위
                        lblResult.Text = "You lose..";
                    }
                }
            }

            

            if(lblResult.Text == "You Win!")
            {
                await Task.Delay(1000);
                form.pnlMain.Controls.Remove(UserChoice);
                form.pnlMain.Controls.Remove(GameResult);
                form.Next_Game();
            }
        }
    }
}
