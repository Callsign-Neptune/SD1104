using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_4___Alex_Chalmers
{
    class ParadiseIsle: baseApps
    {
        public string gender;
        public string nameSO;
        public int yearsDating;

        public ParadiseIsle(string gender, string nameSO, int yearsDating, string firstName, string lastName, string birthday, string address, string cityName, string stateName, int zipCode, string phoneNum, string emailAddress) : base(firstName, lastName, birthday, address, cityName, stateName, zipCode, phoneNum, emailAddress)
        {
            this.gender = gender;
            this.nameSO = nameSO;
            this.yearsDating = yearsDating;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island!");
        }
    }
}
