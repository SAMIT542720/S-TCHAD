using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class UnderWearService : EntityBaseRepository<UnderWear>, IUnderWearService
    {
        public UnderWearService(AppDbContext context) : base(context) { }
    }
}
