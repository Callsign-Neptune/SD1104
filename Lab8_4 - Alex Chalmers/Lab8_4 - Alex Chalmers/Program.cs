using System;

namespace Lab8_4___Alex_Chalmers
{
    class Program
    {
        static void Main(string[] args)
        {
            houseHunters contestantHH = new houseHunters("Full Stack Web Development", 100000, 6, 3, 2, "Omar", "Smith", "02/04/1975", "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");
            ParadiseIsle contestantPI = new ParadiseIsle("female", "Carl", 2, "Patti", "Johnson", "05/04/1994", "211 Love Rd", "Los Angeles", "California", 90001, "988-444-1234", "patti.johnson@gmail.com");
            AboveDeck contestantAD = new AboveDeck(20, "American", "Captian", "Lee", "07/12/1964", "311 Bravo Way", "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com");

            contestantHH.Submit();
            contestantHH.Accept();

            contestantPI.Submit();
            contestantPI.Accept();

            contestantAD.Submit();
            contestantAD.Accept();
        }
    }
}
