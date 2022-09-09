using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpkindof
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter and epic number"); // Tells the user the question for the input
            int reply = int.Parse(Console.ReadLine()); // Gets the users input and parses it to an integer

            for (int i = 1; i < reply + 1; i++) // For loop in order to output each number
            {
                Console.WriteLine(i); // Writes the number to the console
            }*/




            string firstName = "";
            string lastName = "";
            int yearJoined = 0;
            string username = "";

            Console.WriteLine("Enter your firstname: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your lastname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the year you joined: ");
            yearJoined = int.Parse(Console.ReadLine());

            username += yearJoined.ToString().Substring(2, 2);

            if (lastName.Length < 5)
            {
                username += lastName;
            }

            else
            {
                username += lastName.Substring(0, 5);
            }

            username += firstName[0];

            Console.WriteLine(username);

            Console.ReadLine(); // So the console doesn't immediatly close
        }
    }
}
