using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Friendship
    {
        [Key]
        public int User1Id { get; set; }

        public User User1 { get; set; }

        [Key]
        public int User2Id { get; set; }

        public User User2 { get; set; }
    }
}
