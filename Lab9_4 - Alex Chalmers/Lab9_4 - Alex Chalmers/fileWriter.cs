using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4___Alex_Chalmers
{
    class fileWriter
    {
        private const string userLogFile = "C://weblogs//labbylab.txt";

        public void ExampleWriteFile()
        {
            string fileName = "C://weblogs//labbylab.txt";
            string data = "Print this info to a log. \n";
            File.AppendAllText(fileName, data);
        }
        
    }
}
