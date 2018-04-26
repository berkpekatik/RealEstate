using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class MemberModel
    {
        [Required]
        public int MemberId { get; set; }
        
        [Required(ErrorMessage = Constants.UsernameRequired)]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = Constants.PasswordRequired)]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage = Constants.EmailRequired)]
        [MaxLength(50)]
        public string Email { get; set; }

    }
}