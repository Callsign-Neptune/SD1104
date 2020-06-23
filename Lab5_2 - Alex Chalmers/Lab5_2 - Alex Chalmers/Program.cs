using System;
using System.Collections.Generic;

namespace Lab5_2___Alex_Chalmers
{
    class Program
    {
        public enum EndsInY
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            List<string> taskList = new List<string>();
            foreach (EndsInY day in Enum.GetValues(typeof(EndsInY)))
            {
                Console.WriteLine("New task for" + day);
                string task = day + ":" + Console.ReadLine();
                taskList.Add(task);
            }
            foreach(string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
