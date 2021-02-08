using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation //review this class tried implementation of Factory design pattern
    {
        public void CreateMarketingFirmWithManager(string type)
        {
            if(type == "queue" || type == "Queue")
            {
                SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                MarketingFirm marketingFirm = new MarketingFirm(sweepstakesQueueManager);
            }
            else if(type == "stack" || type == "Stack")
            {
                SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                MarketingFirm marketingFirm = new MarketingFirm(sweepstakesStackManager);
            }
            else
            {
                throw new ArgumentException("Invalid type");
            }
        }
    }
}
