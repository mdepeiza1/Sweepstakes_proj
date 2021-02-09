using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class ISweepstakesManagerFactory
    {
        public static ISweepstakesManager SweepstakesManagerFactory(string type)
        {
            switch (type)
            {
                case "stack":
                    ISweepstakesManager ssm1 = new SweepstakesStackManager();
                    return ssm1;
                case "Stack":
                    ISweepstakesManager ssm2 = new SweepstakesStackManager();
                    return ssm2;
                case "queue":
                    ISweepstakesManager sqm1 = new SweepstakesQueueManager();
                    return sqm1;
                case "Queue":
                    ISweepstakesManager sqm2 = new SweepstakesQueueManager();
                    return sqm2;
                default:
                    throw new ArgumentException("Invalid type");
            }
        }
    }
}
