using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class League
    {
        private string _name;
        private List<Team> _teams;
        private List<Match> _matches;


        public string Name { get { return _name; } set { value = _name; } }
        public List<Team> Teams { get { return _teams; } set { value = _teams; } }
        public List<Match> Matches { get { return _matches; } set { value = _matches; } }


        public League(string name)
        {
            _name = name;
            _teams = new List<Team>();
            _matches = new List<Match>();
        }

        public void AddTeam(Team team)
        {
             _teams.Add(team);
        }
        public bool AddMatch(Team t1, Team t2)
        {
            if(t1 == t2)
            {
                return false;
            }
            else
            {
                _matches.Add(new Match(t1, t2));
                return true;
            }
        }

        public int UnplayedCount()
        {
            int count = 0;
            foreach (var match in _matches)
            {
                if (!match.IsPlayed)
                {
                    count++;
                }
            }
            return count;
        }

        public Team Leader()
        {
            Team MostSuccessful = _teams[0];
            foreach(Team item in _teams)
            {
                if (item.Points == MostSuccessful.Points) 
                {
                    if(item.GoalDifference() > MostSuccessful.GoalDifference())
                    {
                        MostSuccessful = item;
                    }
                }
                else if (item.Points > MostSuccessful.Points)
                {
                    MostSuccessful = item;
                }
            }
            return MostSuccessful;
        }
    }
}
