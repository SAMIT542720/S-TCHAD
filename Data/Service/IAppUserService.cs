using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public interface IAppUserService
    {
        Task<AppUser> GetUserByIdAsync(int userid);
    }
}
