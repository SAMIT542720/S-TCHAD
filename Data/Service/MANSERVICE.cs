using Microsoft.EntityFrameworkCore;
using S_TCHAD.Data.Base;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class MANSERVICE : EntityBaseRepository<MAN>, IMANSERVICES
    {
        private readonly AppDbContext _context;
        public MANSERVICE(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task UpdateProductAsync(NewProductVM data)
        {
            var dbmovie = await _context.MANS.FirstOrDefaultAsync(n => n.ID == data.ID);
            if (dbmovie != null)
            {

                dbmovie.Name = data.Name;
                dbmovie.PhotoURL1 = data.PhotoURL1;
                dbmovie.PhotoURL2 = data.PhotoURL2;
                dbmovie.PhotoURL3 = data.PhotoURL3;
                dbmovie.Description = data.Description;
                dbmovie.Sex = data.Sex;
                dbmovie.price = data.price;
                await _context.SaveChangesAsync();
            }
        }
    }
}
