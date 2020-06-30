using System;

namespace Lab7_4___Alex_Chalmers
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile Rick = new DatingProfile("Rick", "Allen", 25, "Male");
            Rick.WriteBio("Tall, handsome runner.");

            DatingProfile Audra = new DatingProfile("Audra", "Williams", 26, "Female");
            Audra.WriteBio("BIG foodie! yoga enthusiast.");

            Audra.sendMessage("HI!", "Wanna grab lunch at this new vegan restaurant?", Rick);
            Rick.ReadMessage();

        }
    }

}
