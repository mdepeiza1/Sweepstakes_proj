using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string EmailAddress
        {
            get;
            set;
        }

        public int RegistrationNumber
        {
            get;
            set;
        }

        public Contestant() //may not be correct implementation
        {
            UserInterface.AssignContestantInfo(this);
        }

        public void Notify(Contestant winner)
        {
            UserInterface.Notify(winner);
        }

        public void NotifyWinner(Contestant winner)
        {
            UserInterface.NotifyWinner(winner);
        }
    }
}
