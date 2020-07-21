using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_4___Alex_Chalmers
{
    class houseHunters: baseApps
    {
        public string jobTitle;
        public int annIncome;
        public int buyDate;
        public int numBed;
        public int numBath;

        public houseHunters(string jobTitle, int annIncome, int buyDate, int numBed, int numBath, string firstName, string lastName, string birthday, string address, string cityName, string stateName, int zipCode, string phoneNum, string emailAddress) : base(firstName, lastName, birthday, address, cityName, stateName, zipCode, phoneNum, emailAddress)
        {
            this.jobTitle = jobTitle;
            this.annIncome = annIncome;
            this.buyDate = buyDate;
            this.numBed = numBed;
            this.numBath = numBath;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters!");
        }
    }
}
