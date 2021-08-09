
namespace SockSockGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtHard = new System.Windows.Forms.RadioButton();
            this.rbtEasy = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNavi = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnReStart = new System.Windows.Forms.Button();
            this.ptbSoundUp = new System.Windows.Forms.PictureBox();
            this.ptbSoundDown = new System.Windows.Forms.PictureBox();
            this.ptbSound = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHowToPlay = new System.Windows.Forms.Panel();
            this.btnHowToOk = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ptbHeart3 = new System.Windows.Forms.PictureBox();
            this.ptbHeart2 = new System.Windows.Forms.PictureBox();
            this.ptbHeart1 = new System.Windows.Forms.PictureBox();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlNavi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSoundUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSoundDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlHowToPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCopyright
            // 
            this.txtCopyright.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCopyright.ForeColor = System.Drawing.Color.Black;
            this.txtCopyright.Location = new System.Drawing.Point(1, 659);
            this.txtCopyright.Multiline = true;
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.ReadOnly = true;
            this.txtCopyright.Size = new System.Drawing.Size(278, 102);
            this.txtCopyright.TabIndex = 6;
            this.txtCopyright.Text = "copyright © in\r\nLeeJaeMin\r\nLeeJaeMin\r\nLeeJaeMin\r\nLeeJaeMin";
            this.txtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("한컴 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(158, 105);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 27);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtHard);
            this.groupBox1.Controls.Add(this.rbtEasy);
            this.groupBox1.Controls.Add(this.rbtNormal);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 65);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "난이도";
            // 
            // rbtHard
            // 
            this.rbtHard.AutoSize = true;
            this.rbtHard.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtHard.ForeColor = System.Drawing.Color.White;
            this.rbtHard.Location = new System.Drawing.Point(10, 20);
            this.rbtHard.Name = "rbtHard";
            this.rbtHard.Size = new System.Drawing.Size(52, 34);
            this.rbtHard.TabIndex = 12;
            this.rbtHard.Text = "상";
            this.rbtHard.UseVisualStyleBackColor = true;
            // 
            // rbtEasy
            // 
            this.rbtEasy.AutoSize = true;
            this.rbtEasy.Checked = true;
            this.rbtEasy.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtEasy.ForeColor = System.Drawing.Color.White;
            this.rbtEasy.Location = new System.Drawing.Point(142, 20);
            this.rbtEasy.Name = "rbtEasy";
            this.rbtEasy.Size = new System.Drawing.Size(52, 34);
            this.rbtEasy.TabIndex = 14;
            this.rbtEasy.TabStop = true;
            this.rbtEasy.Text = "하";
            this.rbtEasy.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtNormal.ForeColor = System.Drawing.Color.White;
            this.rbtNormal.Location = new System.Drawing.Point(76, 20);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(52, 34);
            this.rbtNormal.TabIndex = 13;
            this.rbtNormal.Text = "중";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "점수 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "[ 속 전 속 결 ]";
            // 
            // pnlNavi
            // 
            this.pnlNavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(56)))));
            this.pnlNavi.Controls.Add(this.btnHome);
            this.pnlNavi.Controls.Add(this.btnEnd);
            this.pnlNavi.Controls.Add(this.btnRecord);
            this.pnlNavi.Controls.Add(this.btnReStart);
            this.pnlNavi.Controls.Add(this.ptbSoundUp);
            this.pnlNavi.Controls.Add(this.ptbSoundDown);
            this.pnlNavi.Controls.Add(this.ptbSound);
            this.pnlNavi.Controls.Add(this.groupBox1);
            this.pnlNavi.Controls.Add(this.txtCopyright);
            this.pnlNavi.Controls.Add(this.lblScore);
            this.pnlNavi.Controls.Add(this.label2);
            this.pnlNavi.Controls.Add(this.label1);
            this.pnlNavi.Location = new System.Drawing.Point(-1, -1);
            this.pnlNavi.Name = "pnlNavi";
            this.pnlNavi.Size = new System.Drawing.Size(277, 763);
            this.pnlNavi.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.Location = new System.Drawing.Point(63, 281);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 40);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "처음으로";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnd.Location = new System.Drawing.Point(63, 467);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(150, 40);
            this.btnEnd.TabIndex = 27;
            this.btnEnd.Text = "끝내기";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRecord.Location = new System.Drawing.Point(63, 405);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(150, 40);
            this.btnRecord.TabIndex = 26;
            this.btnRecord.Text = "랭킹";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnReStart
            // 
            this.btnReStart.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReStart.Location = new System.Drawing.Point(63, 343);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(150, 40);
            this.btnReStart.TabIndex = 25;
            this.btnReStart.Text = "다시시작";
            this.btnReStart.UseVisualStyleBackColor = true;
            // 
            // ptbSoundUp
            // 
            this.ptbSoundUp.BackColor = System.Drawing.Color.Transparent;
            this.ptbSoundUp.BackgroundImage = global::SockSockGame.Properties.Resources.plus;
            this.ptbSoundUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSoundUp.Location = new System.Drawing.Point(173, 614);
            this.ptbSoundUp.Name = "ptbSoundUp";
            this.ptbSoundUp.Size = new System.Drawing.Size(40, 30);
            this.ptbSoundUp.TabIndex = 23;
            this.ptbSoundUp.TabStop = false;
            // 
            // ptbSoundDown
            // 
            this.ptbSoundDown.BackColor = System.Drawing.Color.Transparent;
            this.ptbSoundDown.BackgroundImage = global::SockSockGame.Properties.Resources.min;
            this.ptbSoundDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSoundDown.ErrorImage = global::SockSockGame.Properties.Resources.min;
            this.ptbSoundDown.Location = new System.Drawing.Point(116, 614);
            this.ptbSoundDown.Name = "ptbSoundDown";
            this.ptbSoundDown.Size = new System.Drawing.Size(40, 30);
            this.ptbSoundDown.TabIndex = 22;
            this.ptbSoundDown.TabStop = false;
            // 
            // ptbSound
            // 
            this.ptbSound.BackColor = System.Drawing.Color.Transparent;
            this.ptbSound.BackgroundImage = global::SockSockGame.Properties.Resources.Sound;
            this.ptbSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSound.Location = new System.Drawing.Point(57, 612);
            this.ptbSound.Name = "ptbSound";
            this.ptbSound.Size = new System.Drawing.Size(42, 34);
            this.ptbSound.TabIndex = 21;
            this.ptbSound.TabStop = false;
            this.ptbSound.Click += new System.EventHandler(this.ptbSound_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::SockSockGame.Properties.Resources.Main_BG1;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pnlHowToPlay);
            this.pnlMain.Controls.Add(this.ptbHeart3);
            this.pnlMain.Controls.Add(this.ptbHeart2);
            this.pnlMain.Controls.Add(this.ptbHeart1);
            this.pnlMain.Controls.Add(this.lblTimerCount);
            this.pnlMain.Controls.Add(this.btnNext);
            this.pnlMain.Controls.Add(this.lblTimer);
            this.pnlMain.Controls.Add(this.btnHowToPlay);
            this.pnlMain.Controls.Add(this.txtID);
            this.pnlMain.Controls.Add(this.btnStart);
            this.pnlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMain.Location = new System.Drawing.Point(276, -1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(989, 763);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlHowToPlay
            // 
            this.pnlHowToPlay.Controls.Add(this.btnHowToOk);
            this.pnlHowToPlay.Controls.Add(this.textBox3);
            this.pnlHowToPlay.Controls.Add(this.label12);
            this.pnlHowToPlay.Location = new System.Drawing.Point(253, 448);
            this.pnlHowToPlay.Name = "pnlHowToPlay";
            this.pnlHowToPlay.Size = new System.Drawing.Size(481, 302);
            this.pnlHowToPlay.TabIndex = 20;
            this.pnlHowToPlay.Visible = false;
            // 
            // btnHowToOk
            // 
            this.btnHowToOk.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHowToOk.Location = new System.Drawing.Point(204, 272);
            this.btnHowToOk.Name = "btnHowToOk";
            this.btnHowToOk.Size = new System.Drawing.Size(83, 23);
            this.btnHowToOk.TabIndex = 21;
            this.btnHowToOk.Text = "OK";
            this.btnHowToOk.UseVisualStyleBackColor = true;
            this.btnHowToOk.Click += new System.EventHandler(this.btnHowToOk_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(3, 44);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(475, 255);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "정해진 시간은 단 10초!\r\n풀지 못하면 난 어떻게!!!\r\n\r\n\r\n1. 타이머는 5~ 10초 주어지고 이 시간안에 문제를 풀어야 합니다.\r\n2. " +
    "넘어가기는 총 3번 가능합니다. 신중히 사용해주세요!\r\n3. 난이도는 상 중 하 로 이루어져 있습니다.\r\n\r\n최고 기록은 점수 레코드에서 확인할" +
    " 수 있습니다.\r\n최고의 플레이에 도전하세요!";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("한컴 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(160, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 31);
            this.label12.TabIndex = 21;
            this.label12.Text = "How To Play?";
            // 
            // ptbHeart3
            // 
            this.ptbHeart3.BackColor = System.Drawing.Color.Transparent;
            this.ptbHeart3.BackgroundImage = global::SockSockGame.Properties.Resources.hart;
            this.ptbHeart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbHeart3.Location = new System.Drawing.Point(522, 11);
            this.ptbHeart3.Name = "ptbHeart3";
            this.ptbHeart3.Size = new System.Drawing.Size(42, 34);
            this.ptbHeart3.TabIndex = 19;
            this.ptbHeart3.TabStop = false;
            this.ptbHeart3.Visible = false;
            // 
            // ptbHeart2
            // 
            this.ptbHeart2.BackColor = System.Drawing.Color.Transparent;
            this.ptbHeart2.BackgroundImage = global::SockSockGame.Properties.Resources.hart;
            this.ptbHeart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbHeart2.Location = new System.Drawing.Point(462, 11);
            this.ptbHeart2.Name = "ptbHeart2";
            this.ptbHeart2.Size = new System.Drawing.Size(42, 34);
            this.ptbHeart2.TabIndex = 18;
            this.ptbHeart2.TabStop = false;
            this.ptbHeart2.Visible = false;
            // 
            // ptbHeart1
            // 
            this.ptbHeart1.BackColor = System.Drawing.Color.Transparent;
            this.ptbHeart1.BackgroundImage = global::SockSockGame.Properties.Resources.hart;
            this.ptbHeart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbHeart1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ptbHeart1.Location = new System.Drawing.Point(401, 12);
            this.ptbHeart1.Name = "ptbHeart1";
            this.ptbHeart1.Size = new System.Drawing.Size(42, 34);
            this.ptbHeart1.TabIndex = 17;
            this.ptbHeart1.TabStop = false;
            this.ptbHeart1.UseWaitCursor = true;
            this.ptbHeart1.Visible = false;
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.AutoSize = true;
            this.lblTimerCount.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimerCount.Location = new System.Drawing.Point(106, 13);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(19, 21);
            this.lblTimerCount.TabIndex = 12;
            this.lblTimerCount.Text = "0";
            this.lblTimerCount.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNext.Location = new System.Drawing.Point(15, 55);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "넘어가기";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimer.Location = new System.Drawing.Point(15, 13);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(68, 21);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "타이머 : ";
            this.lblTimer.Visible = false;
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnHowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHowToPlay.FlatAppearance.BorderSize = 0;
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToPlay.Font = new System.Drawing.Font("한컴 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.Black;
            this.btnHowToPlay.Location = new System.Drawing.Point(498, 333);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(302, 82);
            this.btnHowToPlay.TabIndex = 15;
            this.btnHowToPlay.Text = "How To Play?";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("한컴 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Location = new System.Drawing.Point(373, 250);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 32);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "이름을 입력해주세요";
            this.txtID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtID_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("한컴 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(184, 333);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(302, 82);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "S T A R T !";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pnlNavi);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlNavi.ResumeLayout(false);
            this.pnlNavi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSoundUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSoundDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHowToPlay.ResumeLayout(false);
            this.pnlHowToPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox ptbHeart3;
        private System.Windows.Forms.PictureBox ptbHeart2;
        private System.Windows.Forms.PictureBox ptbHeart1;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox ptbSoundUp;
        private System.Windows.Forms.PictureBox ptbSoundDown;
        private System.Windows.Forms.PictureBox ptbSound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtHard;
        private System.Windows.Forms.RadioButton rbtEasy;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlHowToPlay;
        private System.Windows.Forms.Button btnHowToOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlNavi;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.Label lblTimerCount;
    }
}

