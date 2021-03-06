﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sweepstakes
{
    static class UserInterface
    {

        public static Contestant AssignContestantInfo(Contestant contestant)
        {
            contestant.FirstName = GetUserInputFor("What is your first name?");
            contestant.LastName = GetUserInputFor("What is your last name?");
            contestant.EmailAddress = GetUserInputFor("What is your email address?");
            contestant.RegistrationNumber = Int32.Parse(GetUserInputFor("What is your registration number?"));
            return contestant;
        }

        public static void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestant.FirstName);
            Console.WriteLine("Last Name: " + contestant.LastName);
            Console.WriteLine("Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber);
        }

        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        public static void Notify(Contestant winner)
        {
            Console.WriteLine("{0} {1} won the sweepstakes!", winner.FirstName, winner.LastName);
        }
        public static void NotifyWinner(Contestant winner)
        {
            Console.WriteLine("Congratulations, {0} {1}, you won the sweepstakes!", winner.FirstName, winner.LastName);
        }
    }
}
