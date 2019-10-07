using System.Threading.Tasks;
using AutoMapper;
using YourBabyDiary.BLL.Dtos;
using YourBabyDiary.BLL.Interfaces;
using YourBabyDiary.BLL.Providers;
using YourBabyDiary.DAL.Entities;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.BLL.Services
{
    public class UserService : BaseService, IParentService
    {
        public UserService(IUnitOfWork uow, IMapper mapper)
            : base(uow, mapper)
        {
        }

        public ParentDto AutheticateParent(string email, string password)
        {
            var parent = _uow.Repository<Parent>().Get(x => x.Email.Equals(email));
            while (true)
            {
                if (IsUserValid(parent, password))
                    break;
                return null;
            }

            return _mapper.Map<ParentDto>(parent);
        }

        public ParentDto GetParent(string email)
        {
            var user = _uow.Repository<Parent>().Get(u => u.Email == email);
            return _mapper.Map<Parent, ParentDto>(user);
        }

        public async Task RegisterUser(ParentDto userDto)
        {
            userDto.Password = HashProvider.Hash(userDto.Password);
            var regUser = _mapper.Map<Parent>(userDto);
            await _uow.Repository<Parent>().Create(regUser);
            await _uow.Commit();
        }

        private bool IsUserValid(Parent parent, string password)
        {
            var hashedPassword = HashProvider.Hash(password);
            return parent?.Password == hashedPassword;
        }
    }
}
