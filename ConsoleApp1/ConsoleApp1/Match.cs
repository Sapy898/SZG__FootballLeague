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
            home = _home;
            away = _away;
            HomeGoals = 0;
            AwayGoals = 0;
            IsPlayed = false;
        }



    }
}
