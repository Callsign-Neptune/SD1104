using System;
using System.Threading.Tasks;

namespace Lab4_6___Alex_Chalmers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] toDo = new string[7];

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine("Create a task for " + weekDays[i]);
                toDo[i] = weekDays[i] + ": " + Console.ReadLine();
            }

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(toDo[i]);
            }
        }
    }
}
