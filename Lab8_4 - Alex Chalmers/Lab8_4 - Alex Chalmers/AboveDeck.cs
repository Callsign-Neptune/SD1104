using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_4___Alex_Chalmers
{
    class AboveDeck: baseApps
    {
        public int yearsExp;
        public string nationality;

        public AboveDeck(int yearsExp, string nationality, string firstName, string lastName, string birthday, string address, string cityName, string stateName, int zipCode, string phoneNum, string emailAddress) : base(firstName, lastName, birthday, address, cityName, stateName, zipCode, phoneNum, emailAddress)
        {
            this.yearsExp = yearsExp;
            this.nationality = nationality;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck!");
        }
    }
}
