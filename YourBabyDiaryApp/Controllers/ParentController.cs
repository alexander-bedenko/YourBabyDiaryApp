using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.BLL.Interfaces;
using YourBabyDiaryApp.Model;

namespace YourBabyDiaryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParentController : ControllerBase
    {
        private readonly IParentService _parentService;

        public ParentController(IParentService parentService)
        {
            _parentService = parentService;
        }

        [HttpGet]
        public Parent Get()
        {
            return Mapper.Map<Parent>(_parentService.GetParent("zylon@mail.ru"));
        }
    }
}
