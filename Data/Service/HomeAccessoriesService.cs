using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class HomeAccessoriesService : EntityBaseRepository<HomeAccessories>, IHomeAccessoriesService
    {
        public HomeAccessoriesService(AppDbContext context) : base(context) { }
    }
}
