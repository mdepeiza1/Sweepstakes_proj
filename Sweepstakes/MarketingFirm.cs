using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager) //Dependency injection is occurring here. The benefit is the type of Manager (stack or queue) does not need to be defined in the initial instantiation.
        {
            _manager = manager; // look here for where to implement your factory method ISweeepStakesManager
        }

        public void CreateSweepstake()
        {
            _manager.InsertSweepstakes(new Sweepstakes(UserInterface.GetUserInputFor("What is the name of the sweepstakes?")));
        }
    }
}
