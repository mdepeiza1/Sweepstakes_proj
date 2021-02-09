using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation //review this class tried implementation of Factory design pattern
    {
        // REFACTOR: Create a separate ISweepStakesManagerFactory class - static class
        // Refactor the method to return type ISweepStakesManager + use a switch case
        public void CreateMarketingFirmWithManager(string type) // this method returns type ISweepStakesManager
        {
            MarketingFirm GoodMarketingFirm = new MarketingFirm(ISweepstakesManagerFactory.SweepstakesManagerFactory(type)); // this is where the factory method to pick sweepstakes managers comes in
        }

        
    }
}
