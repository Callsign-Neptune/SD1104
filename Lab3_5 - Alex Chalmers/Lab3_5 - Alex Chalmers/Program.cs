using System;
using System.Net.Http;

namespace Lab3_5___Alex_Chalmers
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "vodka";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This message is spam.");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
