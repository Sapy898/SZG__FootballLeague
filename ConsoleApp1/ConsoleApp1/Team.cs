using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Team
    {
        private string _name;
        private int _points;
        private int _goalsFor;
        private int _goalsAgainst;

        public string Name { get { return _name; } set { value = _name; } }
        public int Points { get { return _points; } set { value = _points; } }
        public int GoalsFor { get { return _goalsFor; } set { value = _goalsFor; } }
        public int GoalsAgainst { get { return _goalsAgainst; } set { value = _goalsAgainst; } }

        public Team(string name)
        {
            _name = name;
            _points = 0;
            _goalsFor = 0;
            _goalsAgainst = 0;
        }
        public void AddResult(int LG, int KG)
        {
            _goalsFor += LG;
            _goalsAgainst += KG;

        if(LG> KG)
            {
                _points += 3;
            }
        else if ( LG == KG)
            {
                _points =+ 1;
            }
        }

        public int GoalDifference()
        {
            return _goalsFor -= _goalsAgainst;
        }
    }
}
