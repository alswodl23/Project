using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockSockGame
{
    class RankingBoard
    {
        private String Name = "미등록";
        private int Score = 0;

        public RankingBoard() { }

        public void Rank_Update(String _Name, int _Score)
        {
            Name = _Name;
            Score = _Score;
        }

        public String Name_get()
        {
            return Name;
        }

        public int Score_get()
        {
            return Score;
        }
    }
}
