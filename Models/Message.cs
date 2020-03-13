using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int SenderId { get; set; }

        public User Sender { get; set; }

        public int ReceiverId { get; set; }

        public User Reciever { get; set; }

        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        [Required]
        public Boolean IsReceived { get; set; }

        [Required]
        public Boolean IsRead { get; set; }
    }
}
