using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballWorldCupScoreBoard
{
    class LiveScoreBoard
    {
        private List<Match> liveMatches = new List<Match>();
        private List<Match> endedeMatches = new List<Match>();



        //1. Start a game.Our data partners will send us data for the games when they start, and
        //these should capture(Initial score is 0 – 0).
        //a.Home team
        //b.Away team
        public void StartGame(string localTeam, string awayTeam) {
            Match newMatch = new Match(localTeam, awayTeam);

            liveMatches.Add(newMatch);
        }

        //2. Finish game. It will remove a match from the scoreboard.
        public void EndGame(string localTeam) {

            Match matchIndex = FindLiveMatchByLocalTeam(localTeam);

            if (matchIndex != null) { 
                liveMatches.Remove(matchIndex);
                endedeMatches.Add(matchIndex);
            }
            else
                Console.WriteLine("Local Team name not found in the list of active games");

        }

        //3. Update score.Receiving the pair score; home team score and away team score
        //updates a game score.
        public void UpdateScore(string localTeam, int localScore, string awayTeam, int awayScore) {
            Match matchIndex = FindLiveMatchByLocalTeam(localTeam);

            if (matchIndex != null)
            {
                Match currentMatch = liveMatches.Find( x => x == matchIndex);
                currentMatch.homeTeam.currentScore = localScore;
                currentMatch.awayTeam.currentScore = awayScore;
            }
            else
                Console.WriteLine("Match not found in the list of active games");
        }


        //4. Get a summary of games by total score.Those games with the same total score will
        //be returned ordered by the most recently added to our system.
        public string ReturnSummary (){
            string formattedSummary = "";

            foreach (Match match in endedeMatches) { 
                formattedSummary += match.homeTeam.name + " " + match.homeTeam.currentScore + " - " +  match.awayTeam.name + " " + match.awayTeam.currentScore + "\n";
            }

            return formattedSummary;
        }

        private Match FindLiveMatchByLocalTeam(string localTeam) {
            foreach (Match match in liveMatches) {
                if (match.homeTeam.name == localTeam)
                    return match;
            }
            return null;
        }



    }
}
