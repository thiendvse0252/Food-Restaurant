using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Account
    {
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
    }
}
