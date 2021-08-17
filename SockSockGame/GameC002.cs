using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SockSockGame
{
    class GameC002
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        List<string> colors = new List<string>() { "Red", "Orange", "Yellow", "DarkGreen", "Blue", "DarkBlue", "Purple", "Red", "Orange", "Yellow", "DarkGreen", "Blue" };
        List<string> lblColors = new List<string>() { "빨", "주", "노", "초", "파", "남", "보" };
        //List<char> labels = new List<char>() { 'M', 'a', 'k', 'e', 'a', 'R', 'a', 'i', 'n', 'b', 'o', 'w' };
        List<string> labels = new List<string>() { "M", "o", "v", "e", "a", "R", "a", "i", "n", "b", "o", "w" };


        //드래그 중인 picturebox
        PictureBox pbSelected;
        //배경 설정
        internal void InitGame()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.sky;

            int Xplus = 66;
            int lblCoordX = 70;
            int lblCoordY = 0;

            //레이블 생성 및 속성, 등록
            for (int i = 0; i < labels.Count; i++)
            {
                Label lblRainbow = new Label();
                lblRainbow.Text = labels[i];
                //lblRainbow.BringToFront();
                lblRainbow.Size = new Size(60, 48);
                lblRainbow.BackColor = Color.Transparent;
                lblRainbow.Font = new System.Drawing.Font("Arial", 36, System.Drawing.FontStyle.Bold);
                lblRainbow.ForeColor = Color.FromName(colors[i]);

                if(i < 4)
                {
                    lblCoordX += Xplus;
                    lblCoordY = 82;
                }
                else if(i == 4)
                {
                    lblCoordX = 465;
                    lblCoordY = 82;
                }
                else if(i > 4)
                {
                    lblCoordX += Xplus;
                    lblCoordY = 177;
                }
                lblRainbow.Location = new Point(lblCoordX, lblCoordY);

                form.pnlMain.Controls.Add(lblRainbow);
            }

            //컬러박스 패널 및 픽쳐박스 컨트롤 추가 메소드
            CreateColorBox();
            createDropBox();

            //중간 arrow 이미지 생성
            PictureBox rightArrow = new PictureBox();
            rightArrow.BackColor = Color.Transparent;
            rightArrow.BackgroundImage = Properties.Resources.rightArrow;
            rightArrow.BackgroundImageLayout = ImageLayout.Stretch;

            rightArrow.Size = new Size(110, 80);
            rightArrow.Location = new Point(410, 404);

            form.pnlMain.Controls.Add(rightArrow);
        }

        private void PnlMain_DragDrop(object sender, DragEventArgs e)
        {
            var DroppedPb = (PictureBox)e.Data.GetData(typeof(PictureBox));
            ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Panel)sender;

        }

        private void PnlMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        internal void CreateColorBox()
        {
            //패널 생성 및 속성지정
            Panel pnlColor = new Panel();
            
            pnlColor.Location = new Point(168, 270);
            pnlColor.Size = new Size(222, 374);
            pnlColor.BackColor = Color.SkyBlue;
            pnlColor.AllowDrop = true;

            pnlColor.DragEnter += PnlMain_DragEnter;
            pnlColor.DragDrop += PnlMain_DragDrop;

            //컬러픽쳐박스 생성 및 속성지정
            for(int i = 0; i < 7; i++)
            {
                PictureBox pbColor = new PictureBox();

                pbColor.MouseDown += new MouseEventHandler(pbColor_MouseDown);
                pbColor.MouseMove += new MouseEventHandler(pbColor_MouseMove);

                switch (i)
                {
                    case 0:
                        pbColor.Location = new Point(7, 3);
                        break;
                    case 1:
                        pbColor.Location = new Point(113, 3);
                        break;
                    case 2:
                        pbColor.Location = new Point(7, 96);
                        break;
                    case 3:
                        pbColor.Location = new Point(113, 96);
                        break;
                    case 4:
                        pbColor.Location = new Point(7, 189);
                        break;
                    case 5:
                        pbColor.Location = new Point(113, 189);
                        break;
                    case 6:
                        pbColor.Location = new Point(7, 282);
                        break;
                }
                pbColor.Size = new Size(100, 87);
                pbColor.BackColor = Color.FromName(colors[i]);

                pnlColor.Controls.Add(pbColor);
            }

            //설명 레이블 생성 및 속성 추가
            TextBox explanation = new TextBox();
            explanation.Multiline = true;
            explanation.Size = new Size(100, 52);
            explanation.BackColor = Color.SkyBlue;
            explanation.BorderStyle = BorderStyle.None;
            explanation.TextAlign = HorizontalAlignment.Center;
            explanation.Font = new Font("맑은고딕", 12, FontStyle.Bold);
            explanation.Text = "우측 패널로" + Environment.NewLine + "드래그 앤 드롭!";
            explanation.Location = new Point(113, 295);
            explanation.Enabled = false;

            pnlColor.Controls.Add(explanation);


            //Color패널에 등록 후 패널을 main 패널에 등록
            form.pnlMain.Controls.Add(pnlColor);

        }

        //드래그해서 드롭할 패널 생성
        internal void createDropBox()
        {
            Panel DropDestination = new Panel();
            DropDestination.Size = new Size(222, 374);
            DropDestination.BackColor = Color.SkyBlue;
            DropDestination.AllowDrop = true;
            DropDestination.Location = new Point(533, 270);
            
            DropDestination.DragDrop += PnlMain_DragDrop;
            DropDestination.DragEnter += PnlMain_DragEnter;

            //int nX = 10;
            //int nY = 20;

            //for(int i = 0; i < 7; i++)
            //{
            //    Label Color = new Label();
            //    Color.Text = lblColors[i];
            //    Color.Font = new Font("맑은고딕", 40, FontStyle.Bold);
                
            //    Color.Location = new Point(nX, nY);
            //    nX += 95;

            //    DropDestination.Controls.Add(Color);
            //}
            
            form.pnlMain.Controls.Add(DropDestination);
        }

        internal void match_check(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        private void pbColor_MouseDown(object sender, MouseEventArgs e)
        {
            //왼클릭이면 드래그 시작
            if (e.Button == MouseButtons.Left)
            {
                pbSelected = (PictureBox)sender;
                pbSelected.DoDragDrop(pbSelected, DragDropEffects.Copy);
            }
        }
        private void pbColor_MouseMove(object sender, MouseEventArgs e)
        {
            pbSelected = (PictureBox)sender;
            //pbSelected.Location = new Point(e.X, e.Y);
            pbSelected.DoDragDrop(pbSelected, DragDropEffects.Move);
        }

    }
}
