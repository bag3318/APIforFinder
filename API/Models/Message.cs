﻿using System;
using System.Collections.Generic;
using API.Controllers;
using System.Linq;
using System.Web;


namespace API.Models
{
    public class Message
    {
        private string id;
        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string message1;
        public string Message1
        {
            get { return Message1; }
            set { Message1 = value; }
        }
        private string rating;
        public string Rating
        {
            get { return Rating; }
            set { Rating = value; }
        }
        private List<Message> messages;
        public List<Message> Messages
        {
            get { return messages; }
            set { messages = value; }
        }
        private string excptnMsg;
        public string ExcptnMsg
        {
            get { return excptnMsg; }
            set { excptnMsg = value; }

        }
        private bool isDbChangeSuccessful;
        public bool IsDbChangeSuccessful
        {
            get { return isDbChangeSuccessful; }
            set { isDbChangeSuccessful = value; }
        }
        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}