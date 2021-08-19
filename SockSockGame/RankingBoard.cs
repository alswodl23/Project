using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SockSockGame
{
    class RankingBoard
    {
        int Num;
        private string[] RName;
        private string[] RScore;

        public RankingBoard() 
        {
            Num = 10;
            RName = new string[Num];
            RScore = new string[Num];

            for (int i = 0; i < Num; i++)
            {
                RName[i] = null;
                RScore[i] = null;
            }
        }

        public void Add(string _RName, int _RScore)
        {
            for (int i = 0; i < Num; i++)
            {
                if (RName[Num - 1] != null)//배열 자동증가.
                {
                    int numClone = Num;
                    string[] RNameClone = new string[Num];
                    string[] RScoreClone = new string[Num];

                    RNameClone = RName;
                    RScoreClone = RScore;

                    Num += 5;
                    RName = new string[Num];
                    RScore = new string[Num];

                    for (int j = 0; j < Num - 5; j++)
                    {
                        if (RName[j] == null && RNameClone[j] != null)
                        {
                            RName[j] = RNameClone[j];
                            RScore[j] = RScoreClone[j];
                        }
                        else
                        {
                            RName[j] = null;
                            RScore[j] = null;
                        }
                    }
                }

                if (RName[i] == null)
                {
                    RName[i] = _RName;
                    RScore[i] = _RScore.ToString();
                    break;
                }
            }
        }

        public void ReversScore()//내림차순 9,8,7,6... 
        {
            string SaveName = RName[0];
            string SaveScore = RScore[0];

            for (int i = 0; i < Num - 1; i++)
            {
                for (int j = (0 + i); j < Num - 1; j++)
                {
                    if (Convert.ToInt32(RScore[i]) <= Convert.ToInt32(RScore[j + 1]))
                    {
                        SaveScore = RScore[i];
                        RScore[i] = RScore[j + 1];
                        RScore[j + 1] = SaveScore;

                        SaveName = RName[i];
                        RName[i] = RName[j + 1];
                        RName[j + 1] = SaveName;
                    }
                }
            }
        }

        public void clear10()
        {
            int lim = Num - 10;

            for (int i = Num - 1; i >= Num - lim; i--)
            {
                RName[i] = null;
                RScore[i] = null;
            }
        }

        public void RankSave()
        {
            string path1 = @"MyTest1.txt";
            string path2 = @"MyTest2.txt";

            File.WriteAllLines(path1, RName, Encoding.UTF8);
            File.WriteAllLines(path2, RScore, Encoding.UTF8);
        }

        public void RankLoad()
        {
            string path1 = @"MyTest1.txt";
            string path2 = @"MyTest2.txt";

            RName = File.ReadAllLines(path1, Encoding.UTF8);
            RScore = File.ReadAllLines(path2, Encoding.UTF8);
        }

        public String Name_get(int Num)
        {
            return RName[Num - 1];
        }

        public int Score_get(int Num)
        {
            return Convert.ToInt32(RScore[Num - 1]);
        }
    }
}
