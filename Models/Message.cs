using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public User Sender { get; set; }
        public string ReceiverId { get; set; }
        public User Reciever { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }
        public Boolean IsReceived { get; set; }
        public Boolean IsRead { get; set; }
    }
}
