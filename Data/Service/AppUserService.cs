using Microsoft.EntityFrameworkCore;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class AppUserService : IAppUserService
    {
        private readonly AppDbContext _context;
        public AppUserService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<AppUser> GetUserByIdAsync(int userid)
        {
            string stringuserId = userid.ToString();
            return await _context.Users.FirstOrDefaultAsync(n => n.Id == stringuserId);
        }
    }
}
