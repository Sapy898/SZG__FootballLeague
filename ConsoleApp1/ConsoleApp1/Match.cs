using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Match
    {
        private Team _home;
        private Team _away;
        private int _homegoals;
        private int _awayGoasl;
        private bool _isPlayed;

        public Team Home { get { return _home; }set { value = _home; } }
        public Team Away { get { return _away; } set { value = _away; } }
        public int HomeGoals { get { return _homegoals; } set { value = _homegoals; } }
        public int AwayGoals { get { return _awayGoasl; } set { value = _awayGoasl; } }
        public bool IsPlayed { get { return _isPlayed; } set { value = _isPlayed; } }



        public Match(Team home,Team away)
        {
            _home= home;
            _away = away;
            HomeGoals = 0;
            AwayGoals = 0;
            IsPlayed = false;
        }

        public bool Play(int homeGoals, int awayGoals)
        {
            if (IsPlayed)
            {
                return false;
            }
            else if(homeGoals < 0 || awayGoals < 0)
            {
                return false;
            }

            Home.AddResult(homeGoals, awayGoals);
            Away.AddResult(awayGoals, homeGoals);
            IsPlayed = true;

            return true;
        }

        public string Describe()
        {
            if(IsPlayed)
                return $"{Home.Name} - {Away.Name} {HomeGoals}:{AwayGoals}";
            else
                return $"{Home.Name} - {Away.Name} (még nem játszottak)";
        }
    }
}
