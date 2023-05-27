using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class WomenShooeseService: EntityBaseRepository<WomenShooese>, IWomenShooeseService
    {
        public WomenShooeseService(AppDbContext context) : base(context) { }
    }
}
