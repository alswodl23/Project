using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SockSockGame
{
    class GameS004
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        Label title = new Label();


        internal int[,] field;
        internal Button[,] buttons;

        internal void InitGame()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.GameS003BG;
            setGame();
            maintitle();
        }

        internal void init(int width, int height, int bomb)
        {
            field = new int[width, height];
            buttons = new Button[width, height];
            if(bomb > 0.8* width * height)
            {
                bomb = (int)(0.8 * width * height);
            }
            Random ran = new Random();
            while(bomb > 0)
            {
                int x = ran.Next(width);
                int y = ran.Next(height);
                if (field[x, y] == -1)
                    continue;

                field[x, y] = -1;
                
                for (int dx = -1; dx <= 1; dx++)
                {
                    for(int dy = -1; dy <= 1; dy++)
                    {
                        if (x + dx < 0)
                            continue;
                        if (y + dy < 0)
                            continue;
                        if (x + dx >= width)
                            continue;
                        if (y + dy >= height)
                            continue;
                        if (field[x + dx, y + dy] != -1)
                            field[x + dx, y + dy]++;
                    }
                }
                bomb--;
            }
        }

        internal void setGame()
        {
            init(7, 7, 5);
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    Button b = new Button();
                    buttons[x, y] = b;
                    b.Font = new Font("Arial", 40);
                    b.Left = (x * 80) + 240;
                    b.Top = (y * 80) + 160;
                    b.Width = 80;
                    b.Height = 80;
                    b.Text = "";
                    form.pnlMain.Controls.Add(b);
                    b.Click += B_Click;
                }
            }

        }
        internal void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int x = (b.Left - 240) / 80;
            int y = (b.Top - 160) / 80;
            if (field[x, y] == -1)
            {
                b.Text = "X";
                MessageBox.Show("폭탄을 찾았습니다!");
                finishGame();
            }
            else
            {
                if (field[x, y] == 0)
                {
                    b.Text = "";
                    lala(x, y);
                }
                else
                {
                    b.Text = "" + field[x, y];
                }
                b.Enabled = false;
            }
        }
        internal void lala(int x, int y)
        {
            Stack<Point> stapel = new Stack<Point>();
        }

        internal void finishGame()
        {
            form.pnlMain.Controls.Clear();
            form.pnlMain_Add();
            form.Visible_Game_Start();
            form.Next_Game();
        }

        internal void maintitle()
        {
            title.Text = "폭탄을 찾아라!";
            title.Font = new Font("나눔고딕 ExtraBold", 36, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.BackColor = Color.Black;
            title.Location = new Point(327, 82);
            title.AutoSize = true;
            form.pnlMain.Controls.Add(title);
        }
    }
}
