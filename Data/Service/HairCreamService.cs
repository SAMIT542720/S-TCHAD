using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class HairCreamService : EntityBaseRepository<HairCream>, IHairCreamService
    {
        public HairCreamService(AppDbContext context) : base(context) { }
    }
}
