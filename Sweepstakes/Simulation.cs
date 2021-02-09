using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public MarketingFirm marketingFirm;
        public void CreateMarketingFirmWithManager()
        {
            marketingFirm = new MarketingFirm(ISweepstakesManagerFactory.SweepstakesManagerFactory(UserInterface.GetUserInputFor("Should the manager be queue-based or stack-based? Please type stack or queue."))); // this is where the factory method to pick sweepstakes managers comes in
        }
    }
}
