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
{// 1번째 게임 프로젝트 만들기
    class GameK002
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //랜덤번호 뽑기 위한 랜덤객체
        static Random rnd = new Random();
        private int answer;

        Label label1 = new Label();
        TextBox textBox1 = new TextBox();
        Button btnGo = new Button();
        Label lblResult = new Label();

        internal void InitGameK002()
        {// 배경, 텍스트박스, 버튼 세팅
            form1.Visible_Game_Start();
            form1.pnlMain.BackgroundImage = Properties.Resources.HanRiver_01;//배경화면

            // label1      
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("돋움체", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            label1.Location = new System.Drawing.Point(250, 200);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(220, 20);
            label1.TabIndex = 0;
            label1.Text = "Select Between 1~10";
            label1.ForeColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.Transparent;
            form1.pnlMain.Controls.Add(label1);

            // textBox1          
            textBox1.Location = new System.Drawing.Point(390, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(200, 20);
            textBox1.Multiline = true;
            textBox1.TabIndex = 1;
            form1.pnlMain.Controls.Add(textBox1);

            // btnGo          
            btnGo.Location = new System.Drawing.Point(415, 270);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(150, 30);
            btnGo.TabIndex = 2;
            btnGo.Text = "Go!";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += new System.EventHandler(this.btnGo_Click);
            form1.pnlMain.Controls.Add(btnGo);

            // lblResult            
            lblResult.AutoSize = true;
            lblResult.Font = new System.Drawing.Font("굴림", 30.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            lblResult.Location = new System.Drawing.Point(340, 320);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(300, 50);
            lblResult.TabIndex = 4;
            lblResult.Text = " ";
            lblResult.ForeColor = System.Drawing.Color.White;
            lblResult.BackColor = System.Drawing.Color.Transparent;
            form1.pnlMain.Controls.Add(lblResult);

            answer = rnd.Next(1, 10);
            label1.Text = "1부터 10까지의 수들 중 가장 알맞은 숫자를 고르세요.";
            lblResult.Text = "숫자 맞추기 게임!";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int userInput = int.Parse(textBox1.Text);

            if (userInput < answer)
            {
                lblResult.Text = "더 높습니다.";
            }
            else if (userInput > answer)
            {
                lblResult.Text = "더 낮습니다.";
            }
            else
            {
                answer = rnd.Next(1, 10);
                form1.pnlMain.Controls.Clear();
                form1.pnlMain_Add();
                form1.Visible_Game_Start();
                form1.Next_Game();
            }
        }

        private void KeyDownHandler(object sender, HtmlElementEventArgs e)
        {
            if (e.KeyPressedCode == 13)
            {
                e.ReturnValue = false;
                return;
            }
        }
    }
}