using System;

namespace RealEstateApplication.Dtos
{
    public class MemberDto
    {
        public int MemberId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
