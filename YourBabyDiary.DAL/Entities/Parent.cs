﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using YourBabyDiary.DAL.Enums;

namespace YourBabyDiary.DAL.Entities
{
    public class Parent: BaseEntity
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
        public virtual ICollection<Baby> Babies { get; set; } = new HashSet<Baby>();
    }
}
