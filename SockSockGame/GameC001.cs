using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SockSockGame
{
    class GameC001
    {
        //Form1의 요소들에 접근하기 위해 객체 생성
        static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        //랜덤번호 뽑기 위한 랜덤객체
        static Random rand = new Random();

        //게임 클리어 여부 확인을 위한 변수
        int clearBubble = 0;

        //현재 클릭해야하는 숫자
        int shouldClick = 1;

        //버블 좌표 저장 리스트
        List<int> coordList = new List<int>();

        internal void InitGame()
        {
            form.Visible_Game_Start();
            form.pnlMain.BackgroundImage = Properties.Resources.ocean;
            CreateButtons();
        }

        internal void CreateButtons()
        {
            //겹치기 확인용 이전좌표 저장변수
            int prev_x = 0;
            int prev_y = 0;

            for (int i = 0; i < 10; i ++)
            {
                //버튼 생성
                Button myButton = new Button();

                //버튼좌표 생성
                int object_x = rand.Next(55, 900);
                int object_y = rand.Next(160, 580);

                //겹치지 않게 체크
                for (int j = 0; j < coordList.Count; j += 2)
                {
                    if ((coordList[j] <= object_x && object_x <= (coordList[j] + 85)) ||
                        (coordList[j + 1] <= object_y && object_y <= (coordList[j + 1] - 82)))
                    {
                        object_x = rand.Next(55, 900);
                        object_y = rand.Next(160, 580);
                    }
                    else
                    {
                        prev_x = object_x;
                        prev_y = object_y;
                        coordList.Add(prev_x);
                        coordList.Add(prev_y);

                    }
                }

                //버튼 속성 설정
                myButton.BackColor = Color.Transparent;
                myButton.FlatStyle = FlatStyle.Flat;
                myButton.FlatAppearance.BorderSize = 0;
                myButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                myButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                myButton.Image = Properties.Resources.bubble;
                myButton.Text = (i + 1).ToString();
                myButton.Font = new Font("Arial", 30, FontStyle.Bold);
                myButton.Name = string.Format("btn{0}", i + 1);
                myButton.Location = new Point(object_x, object_y);
                myButton.Size = new Size(82, 80);


                //버튼클릭 이벤트 추가
                myButton.Click +=  new EventHandler(btns_Click);

                //버튼 보여주기
                form.pnlMain.Controls.Add(myButton);

            }
        }

        internal void btns_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int curClick = Int32.Parse(btn.Text);

            if(curClick != shouldClick)
            {
                //아무것도 하지않는다
            }
            else
            {
                shouldClick++;
                form.pnlMain.Controls.Remove(btn);
                clearBubble++;
                if(clearBubble == 10)
                {
                    //클리어 및 종료구간
                    form.Next_Game();
                }
            }

        }


        public bool Play()
        {
            InitGame();
            

            return true;
        }

    }
}
