using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class TIRAHSERVICE : EntityBaseRepository<TIRAH>, ITIRAHSERVICE
    {
        public TIRAHSERVICE(AppDbContext context) : base(context) { }
    }
    
}
