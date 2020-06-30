using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4___Alex_Chalmers
{
    class Messages
    {
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        private bool isRead;

        public Messages(string messageTitle, string messageData, DatingProfile sender)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            this.isRead = false;
        }
    }
}
