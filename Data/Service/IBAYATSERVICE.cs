using Microsoft.AspNetCore.Cors.Infrastructure;
using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class IBAYATSERVICE : EntityBaseRepository<IBAYAT_AND_FASATIN>, IIBAYATSERVICE
    {
        public IBAYATSERVICE(AppDbContext context) : base(context) { }
    }
}
