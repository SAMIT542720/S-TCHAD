using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class Backsservice : EntityBaseRepository<Backs>, IBacksservice
    {
        public Backsservice(AppDbContext context) : base(context) { }
    }
}
