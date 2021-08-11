using Service.Entities;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
