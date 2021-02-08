using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public Sweepstakes(string name)
        {
            Name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            var rand = new Random();
            int key = rand.Next(1, contestants.Count + 1);
            Contestant winner = contestants[key];
            winner.NotifyWinner(winner);
            contestants.Remove(key);
            foreach(Contestant c in contestants.Values)
            {
                c.Notify(winner);
            }
            contestants.Add(key, winner); //maybe don't need this
            return contestants[key];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant);
        }
    }
}
