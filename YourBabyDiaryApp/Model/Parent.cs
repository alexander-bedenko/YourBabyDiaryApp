using System.ComponentModel.DataAnnotations;
using YourBabyDiaryApp.Enums;

namespace YourBabyDiaryApp.Model
{
    public class Parent
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
    }
}
