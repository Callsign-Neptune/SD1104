using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4___Alex_Chalmers
{
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> mymessages;

        public DatingProfile (string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            mymessages = new List<Messages>();
        }
        public void WriteBio(string text)
        {
            bio = text;
        }
        public void toInbox(Messages message)
        {
            mymessages.Add(message);
        }
        public void sendMessage(string messageTitle, string messageData, DatingProfile sendTo)
        {
            Messages message = new Messages(messageTitle, messageData, this);
            sendTo.toInbox(message);
        }
        public void ReadMessage()
        {
            foreach(Messages message in mymessages)
            {
                if(message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }
    }
    
}
