using System;
using System.Collections.Generic;
using YourBabyDiary.DAL.Enums;

namespace YourBabyDiary.BLL.Dtos
{
    public class BabyDto: BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ParentDto Parent { get; set; }
        public int ParentId { get; set; }
        public virtual ICollection<EventDto> Events { get; set; } = new HashSet<EventDto>();
    }
}
