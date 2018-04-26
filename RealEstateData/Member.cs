using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateData
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
