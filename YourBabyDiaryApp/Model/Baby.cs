using System;
using YourBabyDiaryApp.Enums;

namespace YourBabyDiaryApp.Model
{
    public class Baby
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ParentId { get; set; }
    }
}
