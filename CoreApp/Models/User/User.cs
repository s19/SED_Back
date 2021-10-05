using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class User
    {
        public string IIN { get; set; }
        public string ShortName { get; set; }
        public string Password { get; set; }
        public List<string> UserRole { get; set; }

    }
}
