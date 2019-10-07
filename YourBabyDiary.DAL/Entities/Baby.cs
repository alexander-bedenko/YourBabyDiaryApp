using System;
using System.Collections.Generic;
using YourBabyDiary.DAL.Enums;

namespace YourBabyDiary.DAL.Entities
{
    public class Baby: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Parent Parent { get; set; }
        public int ParentId { get; set; }
        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
