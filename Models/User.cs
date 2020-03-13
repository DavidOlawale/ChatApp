using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class User: IdentityUser
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public IEnumerable<User> Friends { get; set; }
    }
}
