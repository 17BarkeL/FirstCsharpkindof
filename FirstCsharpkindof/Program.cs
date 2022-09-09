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
            Console.WriteLine("Enter and epic number"); // Tells the user the question for the input
            int reply = int.Parse(Console.ReadLine()); // Gets the users input and parses it to an integer

            for (int i = 1; i < reply + 1; i++) // For loop in order to output each number
            {
                Console.WriteLine(i); // Writes the number to the console
            }

            Console.ReadLine(); // So the console doesn't immediatly close
        }
    }
}
