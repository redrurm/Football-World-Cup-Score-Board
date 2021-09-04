using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballWorldCupScoreBoard
{
    class Match
    {
        private int gameId;
        private Team _homeTeam;
        private Team _awayTeam;

        public Match(string homeTeamName, string awayTeamName) {
            this.homeTeam = new Team(homeTeamName);
            this.awayTeam = new Team(awayTeamName);
        }

        public Team homeTeam {
            get {
                return _homeTeam;
            }
            set {
                _homeTeam = homeTeam;
            }
        }

        public Team awayTeam
        {
            get
            {
                return _awayTeam;
            }
            set
            {
                _awayTeam = awayTeam;
            }
        }
    }
}
