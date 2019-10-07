using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YourBabyDiary.BLL.Interfaces;
using YourBabyDiaryApp.Model;

namespace YourBabyDiaryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParentController : ControllerBase
    {
        private readonly IParentService _parentService;
        private readonly IMapper _mapper;

        public ParentController(IParentService parentService, IMapper mapper)
        {
            _parentService = parentService;
            _mapper = mapper;
        }

        [HttpGet]
        public Parent Get()
        {
            return _mapper.Map<Parent>(_parentService.GetParent("zylon@mail.ru"));
        }
    }
}
