using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            switch (prompt)
            {
                case "Assign Contestant":
                    Contestant contestant = new Contestant();
                    Console.WriteLine("Please enter the first name of the contestant:");
                    contestant.FirstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name of the contestant:");
                    contestant.LastName = Console.ReadLine();
                    Console.WriteLine("Please enter the email address of the contestant:");
                    contestant.EmailAddress = Console.ReadLine();
                    Console.WriteLine("Please enter the registration number of the contestant:");
                    contestant.RegistrationNumber = Int32.Parse(Console.ReadLine());
                    break;
            }
            return "Done";
        }
    }
}
