using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditScoreCard.Models
{
    public class UserInfo
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Email { get; set; }
        public DateTime DateOfbirth { get; set; }
        public string Street { get; set; }
        public string Apt { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Password { get; set; }
        public string Ssn { get; set; }
    }
}