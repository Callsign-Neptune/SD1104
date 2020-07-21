using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_4___Alex_Chalmers
{
    class baseApps
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public string address;
        public string cityName;
        public string stateName;
        public int zipCode;
        public string phoneNum;
        public string emailAddress;
        public bool appSubmit;
        public bool appAccept;

        baseApps (string firstName, string lastName, string birthday, string address, string cityName, string stateName, int zipCode, string phoneNum, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.address = address;
            this.cityName = cityName;
            this.stateName = stateName;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
            this.emailAddress = emailAddress;
            appSubmit = false;
            appAccept = false;
        }

        public void Submit()
        {
            appSubmit = true;
            Console.WriteLine("Application has been submitted.");
        }
        public virtual void Accept()
        {
            appAccept = true;
            Console.WriteLine("Application accepted!");
        }
    }
}
