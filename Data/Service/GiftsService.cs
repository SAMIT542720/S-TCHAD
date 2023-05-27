using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class GiftsService : EntityBaseRepository<Gifts>, IGiftsService
    {
        public GiftsService(AppDbContext context) : base(context) { }
    }
}
