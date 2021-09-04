using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballWorldCupScoreBoard
{
    class Team
    {
        private string _name;
        private int _currentScore;


        public Team(string teamName) {
            this.name = teamName;
            this.currentScore = 0;
        }

        public string name
        {
            get {
                return _name;
            }
            set
            {
                _name = name;
            }
        }

        public int currentScore
        {
            get
            {
                return _currentScore;
            }
            set
            {
                _currentScore = currentScore;
            }
        }

    }
}
