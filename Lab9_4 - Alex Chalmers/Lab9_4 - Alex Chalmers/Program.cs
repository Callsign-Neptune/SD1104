using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace Lab9_4___Alex_Chalmers
{
    class header
    {
        public const string open = "<h1>";
        public const string close = "</h1>";
        public string makeHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }
    }
    class unList
    {
        public const string open = "<ul>";
        public const string close = "</ul>";
        public string makeList(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";
            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }
        public StringBuilder CreateList(string[] listItems)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);
            return sb;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            string filename = "C://weblogs//labbylab.html";
            header header = new header();
            unList list = new unList();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Make an HTML header!");
            string headerElement = header.makeHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add an item!");
                listItems[i] = list.makeList(Console.ReadLine());
            }
            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(headerElement);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());
        }
    }
}
