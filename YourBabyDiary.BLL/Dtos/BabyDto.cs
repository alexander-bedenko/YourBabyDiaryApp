﻿using System;
using YourBabyDiary.BLL.Enums;

namespace YourBabyDiary.BLL.Dtos
{
    public class BabyDto: BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ParentId { get; set; }
    }
}
