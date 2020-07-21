using System;
using System.Diagnostics.Contracts;

namespace Lab5_6___Alex_Chalmers
{
    class Program
    {
        public struct Customer
        {
            public string firstName;
            public string lastName;
            public int age;
            public string gender;
            public bool premiumMember;

        }


        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.firstName = "Thomas";
            customer1.lastName = "Paul";
            customer1.age = 16;
            customer1.premiumMember = false;

            customer2.firstName = "Rick";
            customer2.lastName = "Allen";
            customer2.age = 25;
            customer2.premiumMember = false;

            customer3.firstName = "Trisha";
            customer3.lastName = "Smithson";
            customer3.age = 33;
            customer3.premiumMember = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if(allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is not allowed to purchase alcohol.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " can purchase alcohol.");
                }
                if (allCustomers[i].premiumMember == true)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " has a premium membership.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " has a standard membership.");
                }
            }
        }
    }
}
