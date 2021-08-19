using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SockSockGame
{ // 2번째 게임 프로젝트 만들기
	class GameK001
	{
		//Form1의 요소들에 접근하기 위해 객체 생성
		static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

		//랜덤번호 뽑기 위한 랜덤객체
		static Random rand = new Random();

		private int plus1, plus2, minus1, minus2, multi1, multi2, div1, div2;

		// 전역변수 선언
		// 1. Button 부분
		public Button btnStart = new Button();
		public Button btnNext = new Button();

		// 2. Label 부분
		public Label timeLabel = new Label();
		public Label lblNotice = new Label();

		public Label plusLeftLabel = new Label();
		public Label plusLabel = new Label();
		public Label plusRightLabel = new Label();
		public Label lblEqual1 = new Label();

		public Label minusLeftLabel = new Label();
		public Label minusLabel = new Label();
		public Label minusRightLabel = new Label();
		public Label lblEqual2 = new Label();

		public Label multiLeftLabel = new Label();
		public Label multiLabel = new Label();
		public Label multiRightLabel = new Label();
		public Label lblEqual3 = new Label();

		public Label divLeftLabel = new Label();
		public Label divLabel = new Label();
		public Label divRightLabel = new Label();
		public Label lblEqual4 = new Label();
	
		// 3. TextBox 부분
		TextBox txtPlus = new TextBox();
		TextBox txtMinus = new TextBox();
		TextBox txtMulti = new TextBox();
		TextBox txtDivide = new TextBox();

		internal void InitGameK001()
		{
			form.Visible_Game_Start();
			form.pnlMain.BackgroundImage = Properties.Resources.Beach01;

			// Label 속성:AutoSize, Font, Location, Name, Size, TabIndex, Text, ForeColor, BackColor			
			timeLabel.AutoSize = true;
			timeLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			timeLabel.Location = new System.Drawing.Point(247, 416);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new System.Drawing.Size(0, 24);
			timeLabel.TabIndex = 23;
			timeLabel.Text = "";
			
			// A + B = ?
			plusLeftLabel.AutoSize = true;
			plusLeftLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			plusLeftLabel.Location = new System.Drawing.Point(247, 200);
			plusLeftLabel.Name = "plusLeftLabel";
			plusLeftLabel.Size = new System.Drawing.Size(28, 26);
			plusLeftLabel.TabIndex = 3;
			plusLeftLabel.Text = "?";
			
			plusLabel.AutoSize = true;
			plusLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			plusLabel.Location = new System.Drawing.Point(297, 200);
			plusLabel.Name = "plusLabel";
			plusLabel.Size = new System.Drawing.Size(28, 26);
			plusLabel.TabIndex = 4;
			plusLabel.Text = "+";
			
			plusRightLabel.AutoSize = true;
			plusRightLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			plusRightLabel.Location = new System.Drawing.Point(347, 200);
			plusRightLabel.Name = "plusRightLabel";
			plusRightLabel.Size = new System.Drawing.Size(28, 26);
			plusRightLabel.TabIndex = 5;
			plusRightLabel.Text = "?";
			
			lblEqual1.AutoSize = true;
			lblEqual1.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			lblEqual1.Location = new System.Drawing.Point(397, 200);
			lblEqual1.Name = "lblEqual1";
			lblEqual1.Size = new System.Drawing.Size(28, 26);
			lblEqual1.TabIndex = 15;
			lblEqual1.Text = "=";
			
			// A - B = ?
			minusLeftLabel.AutoSize = true;
			minusLeftLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			minusLeftLabel.Location = new System.Drawing.Point(247, 240);
			minusLeftLabel.Name = "minusLeftLabel";
			minusLeftLabel.Size = new System.Drawing.Size(28, 26);
			minusLeftLabel.TabIndex = 6;
			minusLeftLabel.Text = "?";
			
			minusLabel.AutoSize = true;
			minusLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			minusLabel.Location = new System.Drawing.Point(297, 240);
			minusLabel.Name = "minusLabel";
			minusLabel.Size = new System.Drawing.Size(28, 26);
			minusLabel.TabIndex = 7;
			minusLabel.Text = "-";
			
			minusRightLabel.AutoSize = true;
			minusRightLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			minusRightLabel.Location = new System.Drawing.Point(347, 240);
			minusRightLabel.Name = "minusRightLabel";
			minusRightLabel.Size = new System.Drawing.Size(28, 26);
			minusRightLabel.TabIndex = 8;
			minusRightLabel.Text = "?";
			
			lblEqual2.AutoSize = true;
			lblEqual2.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			lblEqual2.Location = new System.Drawing.Point(397, 240);
			lblEqual2.Name = "lblEqual2";
			lblEqual2.Size = new System.Drawing.Size(28, 27);
			lblEqual2.TabIndex = 16;
			lblEqual2.Text = "=";
			
			// A * B = ?
			multiLeftLabel.AutoSize = true;
			multiLeftLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			multiLeftLabel.Location = new System.Drawing.Point(247, 280); 
			multiLeftLabel.Name = "multiLeftLabel";
			multiLeftLabel.Size = new System.Drawing.Size(28, 26);
			multiLeftLabel.TabIndex = 9;
			multiLeftLabel.Text = "?";
			
			multiLabel.AutoSize = true;
			multiLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			multiLabel.Location = new System.Drawing.Point(297, 280);
			multiLabel.Name = "multiLabel";
			multiLabel.Size = new System.Drawing.Size(28, 26);
			multiLabel.TabIndex = 10;
			multiLabel.Text = "×";
			
			multiRightLabel.AutoSize = true;
			multiRightLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			multiRightLabel.Location = new System.Drawing.Point(347, 280);
			multiRightLabel.Name = "multiRightLabel";
			multiRightLabel.Size = new System.Drawing.Size(28, 26);
			multiRightLabel.TabIndex = 11;
			multiRightLabel.Text = "?";
			
			lblEqual3.AutoSize = true;
			lblEqual3.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			lblEqual3.Location = new System.Drawing.Point(397, 280);
			lblEqual3.Name = "lblEqual3";
			lblEqual3.Size = new System.Drawing.Size(28, 26);
			lblEqual3.TabIndex = 17;
			lblEqual3.Text = "=";
			
			// A / B = ?
			divLeftLabel.AutoSize = true;
			divLeftLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			divLeftLabel.Location = new System.Drawing.Point(247, 320); 
			divLeftLabel.Name = "divLeftLabel";
			divLeftLabel.Size = new System.Drawing.Size(28, 26);
			divLeftLabel.TabIndex = 12;
			divLeftLabel.Text = "?";
			
			divLabel.AutoSize = true;
			divLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			divLabel.Location = new System.Drawing.Point(297, 320);
			divLabel.Name = "divLabel";
			divLabel.Size = new System.Drawing.Size(28, 26);
			divLabel.TabIndex = 13;
			divLabel.Text = "÷";
			
			divRightLabel.AutoSize = true;
			divRightLabel.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			divRightLabel.Location = new System.Drawing.Point(347, 320);
			divRightLabel.Name = "divRightLabel";
			divRightLabel.Size = new System.Drawing.Size(28, 26);
			divRightLabel.TabIndex = 14;
			divRightLabel.Text = "?";
			
			lblEqual4.AutoSize = true;
			lblEqual4.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			lblEqual4.Location = new System.Drawing.Point(397, 320);
			lblEqual4.Name = "lblEqual4";
			lblEqual4.Size = new System.Drawing.Size(28, 26);
			lblEqual4.TabIndex = 18;
			lblEqual4.Text = "=";

			lblNotice.AutoSize = true;
			lblNotice.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			lblNotice.Location = new System.Drawing.Point(247, 360);
			lblNotice.Name = "lblNotice";
			lblNotice.Size = new System.Drawing.Size(408, 22);
			lblNotice.TabIndex = 34;
			lblNotice.Text = "나누기 문제는 정수로만 입력해주세요.";
			lblNotice.ForeColor = System.Drawing.Color.Black;
			lblNotice.Visible = true;

			// Button 속성: Location, Name, Size, TabIndex, Text, BackColor, Click
			btnStart.Location = new System.Drawing.Point(247, 450);
			btnStart.Name = "btnStart";
			btnStart.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)129));
			btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btnStart.Size = new System.Drawing.Size(160, 42);
			btnStart.TabIndex = 2;
			btnStart.Text = "Start Quiz!";
			btnStart.UseVisualStyleBackColor = true;
			btnStart.Click += new System.EventHandler(this.btnStart_Click);
			btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;		
			btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

			// TextBox 속성: Location, Name, Size, TabIndex
			txtPlus.Location = new System.Drawing.Point(447, 200);
			txtPlus.Name = "txtPlus";
			txtPlus.Size = new System.Drawing.Size(130, 20);
			txtPlus.TabIndex = 29;

			txtMinus.Location = new System.Drawing.Point(447, 240);
			txtMinus.Name = "txtMinus";
			txtMinus.Size = new System.Drawing.Size(130, 20);
			txtMinus.TabIndex = 30;

			txtMulti.Location = new System.Drawing.Point(447, 280);
			txtMulti.Name = "txtMulti";
			txtMulti.Size = new System.Drawing.Size(130, 20);
			txtMulti.TabIndex = 31;

			txtDivide.Location = new System.Drawing.Point(447, 320);
			txtDivide.Name = "txtDivide";
			txtDivide.Size = new System.Drawing.Size(130, 20);
			txtDivide.TabIndex = 32;

			// MainPanel에 게임 프로그램 가져오기 (패널 추가)
			form.pnlMain.Controls.Add(btnStart);
			form.pnlMain.Controls.Add(timeLabel);
			form.pnlMain.Controls.Add(lblNotice);

			form.pnlMain.Controls.Add(divLeftLabel);
			form.pnlMain.Controls.Add(divLabel);
			form.pnlMain.Controls.Add(divRightLabel);
			form.pnlMain.Controls.Add(lblEqual4);

			form.pnlMain.Controls.Add(multiLeftLabel);
			form.pnlMain.Controls.Add(multiLabel);
			form.pnlMain.Controls.Add(multiRightLabel);
			form.pnlMain.Controls.Add(lblEqual3);

			form.pnlMain.Controls.Add(minusLeftLabel);
			form.pnlMain.Controls.Add(minusLabel);
			form.pnlMain.Controls.Add(minusRightLabel);
			form.pnlMain.Controls.Add(lblEqual2);

			form.pnlMain.Controls.Add(plusLeftLabel);
			form.pnlMain.Controls.Add(plusLabel);
			form.pnlMain.Controls.Add(plusRightLabel);
			form.pnlMain.Controls.Add(lblEqual1);

			form.pnlMain.Controls.Add(txtPlus);
			form.pnlMain.Controls.Add(txtMinus);
			form.pnlMain.Controls.Add(txtMulti);
			form.pnlMain.Controls.Add(txtDivide);

			StartTheQuiz();
			btnStart.Enabled = true;
		}

		private void StartTheQuiz()
		{
			plus1 = rand.Next(1, 10);
			plus2 = rand.Next(1, 10);
			plusLeftLabel.Text = plus1.ToString();
			plusRightLabel.Text = plus2.ToString();

			minus1 = rand.Next(1, 10);
			minus2 = rand.Next(1, 10);
			minusLeftLabel.Text = minus1.ToString();
			minusRightLabel.Text = minus2.ToString();

			multi1 = rand.Next(1, 10);
			multi2 = rand.Next(1, 10);
			multiLeftLabel.Text = multi1.ToString();
			multiRightLabel.Text = multi2.ToString();

			div1 = rand.Next(1, 10);
			div2 = rand.Next(1, 10);
			divLeftLabel.Text = div1.ToString();
			divRightLabel.Text = div2.ToString();

		}

		private void CheckTheAnswer()
		{
			if ((plus1 + plus2 == int.Parse(txtPlus.Text))
				&& (minus1 - minus2 == int.Parse(txtMinus.Text))
				&& (multi1 * multi2 == int.Parse(txtMulti.Text))
				&& (div1 / div2 == int.Parse(txtDivide.Text)))
			{
				form.pnlMain.Controls.Clear();
				form.pnlMain_Add();
				form.Visible_Game_Start();
				form.Next_Game();
			}
			else
			{
				timeLabel.Text = "틀린 문제가 있습니다. 다시 푸세요.";
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			CheckTheAnswer();
		}
	}
}
