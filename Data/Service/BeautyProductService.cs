using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class BeautyProductService : EntityBaseRepository<BeautyProduct>, IBeautyProductService
    {
        public BeautyProductService(AppDbContext context) : base(context) { }
    }
}
