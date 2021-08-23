using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SockSockGame
{
    class GameS001
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        // 폼 구현을 위한 객체 생성
        TextBox tbInput = new TextBox();

        Button btnEnter = new Button();

        Label lblWord00 = new Label();
        Label lblWord01 = new Label();
        Label lblWord02 = new Label();

        Random ran = new Random();

        // 정답 맞춘 횟수
        int correctCount = 0;

        // 오타 기회 횟수
        int countWrong = 3;

        // 단여 배열
        string[] word = { "거울", "얼굴", "조심성", "음영", "주름", "손가락", "대열", "모습", "사랑", "공격", "웃음", "침대", "긴장",
                "시간", "휴식", "열정", "창문", "배회", "안정", "비", "방" };

        // 게임 시작
        internal void InitGame()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.GameS001BG;
            setGame();
        }

        internal void setGame()
        {
            // 단어 리스트 인덱스 랜덤 넘버링
            int wordRan00 = ran.Next(word.Length);
            int wordRan01 = ran.Next(word.Length);
            int wordRan02 = ran.Next(word.Length);

            // 단어 배치 랜덤으로 설정
            int[] wordX = new int[3];
            int[] wordY = new int[3];

            for(int i = 0; i < 3; i++)
            {
                wordX[i] = ran.Next(50, 800);
                wordY[i] = ran.Next(50, 500);
            }

            // 단어 입력창 속성 및 화면 출력
            tbInput.Size = new Size(150, 50);
            tbInput.Font = new Font("Arial", 30, FontStyle.Bold);
            tbInput.Location = new Point(400, 650);
            form.pnlMain.Controls.Add(tbInput);

            // 버튼 입력창 속성 및 화면 출력
            btnEnter.Text = "입력";
            btnEnter.Font = new Font("Arial", 30, FontStyle.Bold);
            btnEnter.Size = new Size(120, 50);
            btnEnter.Location = new Point(570, 650);
            form.pnlMain.Controls.Add(btnEnter);

            // 랜덤 단어를 화면에 출력
            showWord(lblWord00, wordRan00, wordX[0], wordY[0]);
            showWord(lblWord01, wordRan01, wordX[1], wordY[1]);
            showWord(lblWord02, wordRan02, wordX[2], wordY[2]);

            // 입력 버튼 클릭하거나 엔터를 누르면 단어가 입력되는 이벤트
            btnEnter.Click += btnEnter_Click;
            tbInput.KeyDown += tbInput_KeyDown;
        }

        // 단어 레이블 속성
        internal void showWord(Label wordLabel, int num, int xLoc, int yLoc)
        {
            wordLabel.Font = new Font("Arial", 30, FontStyle.Bold);
            wordLabel.AutoSize = true;
            wordLabel.BackColor = Color.Transparent;
            wordLabel.Text = word[num].ToString();
            wordLabel.Location = new Point(xLoc, yLoc);
            form.pnlMain.Controls.Add(wordLabel);
        }

        internal void initTextbox()
        {
            tbInput.Text = "";
        }
        // 엔터키 눌렀을 때 입력 가능
        internal void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(sender, e);
                initTextbox();
            }
        }

        // 화면에 띄워진 단어와 입력한 단어가 같을때 띄워진 단어가 사라짐, 오타 3번 입력 시 게임 자동 종료
        internal void btnEnter_Click(object sender, EventArgs e)
        {
            correctWord();
        }
        internal void correctWord()
        {
            if (tbInput.Text == lblWord00.Text)
            {
                form.pnlMain.Controls.Remove(lblWord00);
                correctCount++;
            }
            else if (tbInput.Text == lblWord01.Text)
            {
                form.pnlMain.Controls.Remove(lblWord01);
                correctCount++;
            }
            else if (tbInput.Text == lblWord02.Text)
            {
                form.pnlMain.Controls.Remove(lblWord02);
                correctCount++;
            }
            else
            {
                countWrong--;
                if (countWrong == 2)
                {
                    MessageBox.Show("틀렸습니다. 기회가 2번 남았습니다.");
                    initTextbox();
                }
                else if (countWrong == 1)
                {
                    MessageBox.Show("틀렸습니다. 기회가 1번 남았습니다.");
                    initTextbox();
                }
                else
                {
                    MessageBox.Show("기회를 모두 사용하였습니다.");
                    form.Next_Game();
                }
            }

            if(correctCount == 3)
            {
                tbInput.Text = "";
                // 게임종료
                form.pnlMain.Controls.Clear();
                form.pnlMain_Add();
                form.Visible_Game_Start();
                form.Next_Game();
            }
        }
    }
}
