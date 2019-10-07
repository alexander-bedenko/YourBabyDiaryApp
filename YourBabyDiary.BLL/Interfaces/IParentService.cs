using System.Threading.Tasks;
using YourBabyDiary.BLL.Dtos;

namespace YourBabyDiary.BLL.Interfaces
{
    public interface IParentService
    {
        ParentDto AutheticateParent(string email, string password);
        Task RegisterUser(ParentDto parentDto);
        ParentDto GetParent(string email);
    }
}
