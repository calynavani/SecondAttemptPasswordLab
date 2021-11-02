using System;
using System.Collections.Generic;

namespace SecondAttemptAtPasswordLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");
            int numOfUsers = 5;

            const int SIZE = 5;

            string[] userNames = new string[SIZE];
            userNames[0] = "Calyn123";

            string[] passWords = new string[SIZE];
            passWords[0] = "Abc123!@#";

            string find

          


            Console.WriteLine("Let's create a password");
            Console.Write("The password must contain: \no At least one lowercase letter\no At least one uppercase letter\no At least one number\no A minimun of 7 characters\no A maximum of 12 characters\no Can include any of the following special characters(! @ # $ % ^ & *): ");
            string password = Console.ReadLine();

            Console.WriteLine("Lets now create a username.");
            Console.Write("The user name must contain: \no Must contain both letters and numbers\no Must have at minimum 5 letters\no At minimum lenght of 7 characters\no At maxium 12 characters: ");
            string username = Console.ReadLine();

           

        }
    }
}
