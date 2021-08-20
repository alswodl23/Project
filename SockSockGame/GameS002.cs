using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SockSockGame
{
    class GameS002
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        // 랜덤 객체 생성
        Random ran = new Random();

        Label lblO = new Label();
        Label lblX = new Label();

        Label lblNum1 = new Label();
        TextBox tbCal = new TextBox();
        Label lblNum2 = new Label();
        Label lblEqual = new Label();
        Label lblResult = new Label();

        Button plusBtn = new Button();
        Button minusBtn = new Button();
        Button mulBtn = new Button();
        Button divideBtn = new Button();

        // 랜덤 정수 변수
        int num1, num2 = 1;
        // 레이블에
        int ranNum1, ranNum2 = 0;

        // 정답 맞춘 횟수
        int correctCount = 0;

        // 오답 기회 횟수
        int wrongCount = 3;

        internal void InitGame()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.GameS002BG;
            setDesign();
            startGame();
        }
        internal void startGame()
        {
            setArithmetic();
            enabledButtons(true);

            finishGame();
        }
        internal void setDesign()
        {
            lblNum1.Text = "0";
            setNum(lblNum1, 247, 226);

            tbCal.Text = "";
            setCal(tbCal, 353, 226);

            lblNum2.Text = "0";
            setNum(lblNum2, 459, 226);

            lblEqual.Text = "=";
            setNum(lblEqual, 565, 226);

            lblResult.Text = "";
            setNum(lblResult, 671, 226);

            plusBtn.Text = "+";
            setButton(plusBtn, 291, 354);

            minusBtn.Text = "-";
            setButton(minusBtn, 503, 354);

            mulBtn.Text = "*";
            setButton(mulBtn, 291, 467);

            divideBtn.Text = "/";
            setButton(divideBtn, 503, 467);

            setLabelO(lblO);
            setLabelX(lblX);

            // 버튼 및 레이블 클릭 이벤트
            plusBtn.Click += plusBtn_Click;
            minusBtn.Click += minusBtn_Click;
            mulBtn.Click += mulBtn_Click;
            divideBtn.Click += divideBtn_Click;

            lblO.Click += lblO_Click;
            lblX.Click += lblX_Click;
        }
        internal void setArithmetic()
        {
            // 랜덤 정수 생성
            num1 = ran.Next(1, 10);
            num2 = ran.Next(1, 10);

            // 랜덤 숫자를 레이블에 넘겨줌
            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();

            // 계산을 위해 정수로 변환
            ranNum1 = Convert.ToInt32(lblNum1.Text);
            ranNum2 = Convert.ToInt32(lblNum2.Text);

            // 랜덤수 사칙연산
            int resultPlus = Plus(ranNum1, ranNum2);
            int resultMinus = Minus(ranNum1, ranNum2);
            int resultMultiple = Multiple(ranNum1, ranNum2);
            int resultDivide = Divide(ranNum1, ranNum2);

            // 사칙연산을 랜덤으로 설정할 수 있도록 배열 선언
            int[] arithmatic = { resultPlus, resultMinus, resultMultiple, resultDivide };
            int choose = ran.Next(0, 3);
            lblResult.Text = Convert.ToString(arithmatic[choose]);
        }

        internal void plusBtn_Click(object sender, EventArgs e)
        {
            int correct = Plus(num1, num2);
            showOX(correct);
        }
        internal void minusBtn_Click(object sender, EventArgs e)
        {
            int correct = Minus(num1, num2);
            showOX(correct);
        }
        internal void mulBtn_Click(object sender, EventArgs e)
        {
            int correct = Multiple(num1, num2);
            showOX(correct);
        }
        internal void divideBtn_Click(object sender, EventArgs e)
        {
            int correct = Divide(num1, num2);
            showOX(correct);
        }
        internal void lblO_Click(object sender, EventArgs e)
        {
            correctCount++;
            lblO.Visible = false;
            startGame();
        }
        internal void lblX_Click(object sender, EventArgs e)
        {
            wrongCount--;
            lblX.Visible = false;
            startGame();
        }

        internal void setNum(Label wordLabel, int xLoc, int yLoc)
        {
            wordLabel.Font = new Font("Arial", 50, FontStyle.Bold);
            wordLabel.ForeColor = Color.White;
            wordLabel.BackColor = Color.Transparent;
            wordLabel.Location = new Point(xLoc, yLoc);
            wordLabel.AutoSize = true;
            form.pnlMain.Controls.Add(wordLabel);
        }
        internal void setCal(TextBox calculate, int xLoc, int yLoc)
        {
            calculate.Font = new Font("Arial", 50, FontStyle.Bold);
            calculate.ForeColor = Color.White;
            calculate.Multiline = true;
            calculate.Location = new Point(xLoc, yLoc);
            calculate.Size = new Size(74, 77);
            calculate.ReadOnly = true;
            form.pnlMain.Controls.Add(calculate);
        }
        internal void setButton(Button btn, int x, int y)
        {
            btn.Location = new Point(x, y);
            btn.Font = new Font("Arial", 48, FontStyle.Bold);
            btn.Size = new Size(180, 80);
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Lime;
            btn.ForeColor = Color.Black;
            form.pnlMain.Controls.Add(btn);
        }

        internal void setLabelO(Label oLabel)
        {
            oLabel.Visible = false;
            oLabel.Text = "O";
            oLabel.Font = new Font("Arial", 150, FontStyle.Bold);
            oLabel.ForeColor = Color.White;
            oLabel.BackColor = Color.Blue;
            oLabel.Location = new Point(360, 276);
            oLabel.AutoSize = true;
            form.pnlMain.Controls.Add(oLabel);
        }
        internal void setLabelX(Label xLabel)
        {
            xLabel.Visible = false;
            xLabel.Text = "X";
            xLabel.Font = new Font("Arial", 150, FontStyle.Bold);
            xLabel.ForeColor = Color.White;
            xLabel.BackColor = Color.Red;
            xLabel.Location = new Point(360, 276);
            xLabel.AutoSize = true;
            form.pnlMain.Controls.Add(xLabel);
        }

        internal void showOX(int correct)
        {
            if (correct == Convert.ToInt32(lblResult.Text))
            {
                enabledButtons(false);
                lblO.Visible = true;
                lblO.BringToFront();
            }
            else
            {
                enabledButtons(false);
                lblX.Visible = true;
                lblX.BringToFront();
            }
        }
        internal void enabledButtons(bool x)
        {
            plusBtn.Enabled = x;
            minusBtn.Enabled = x;
            mulBtn.Enabled = x;
            divideBtn.Enabled = x;
        }

        internal int Plus(int a, int b) { return a + b; }
        internal int Minus(int a, int b) { return a - b; }
        internal int Multiple(int a, int b) { return a * b; }
        internal int Divide(int a, int b) { return a / b; }

        internal void finishGame()
        {
            if (correctCount >= 5)
            {
                form.pnlMain.Controls.Clear();
                form.pnlMain_Add();
                form.Visible_Game_Start();
                form.Next_Game();
                // 다음으로 넘어가기
            }
            if (wrongCount == 0)
            {
                MessageBox.Show("실패!");
                // 다음으로 넘어가기
            }
        }
    }
}