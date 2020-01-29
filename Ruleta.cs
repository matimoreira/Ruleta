using System;
using System.Collections.Generic;
using System.Text;

namespace Ruleta
{
    class Ruleta
    {
        private List<int> _bets;
        public Ruleta()
        {
            _bets = new List<int>();
        }
        public void addBets(int value)
        {
            _bets.Add(value);
        }
        public List<int> getAllBets()
        {
            return _bets;
        }
        public int getNumberWin()
        {
            var rand = new Random();
            return rand.Next(0, 36);
        }
        public int getResults(int numberWin)
        {
            int winners = 0;
            foreach (var bet in _bets)
            {
                if (bet == numberWin)
                {
                    winners++;
                }
            }
            return winners;
        }
    }
}
