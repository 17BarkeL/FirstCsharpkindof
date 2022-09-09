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
            Console.WriteLine("Enter and epic number");
            int reply = int.Parse(Console.ReadLine());

            for (int i = 1; i < reply + 1; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
