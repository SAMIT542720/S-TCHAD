using S_TCHAD.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace S_TCHAD.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Gifts> Giftses { get; set; }
        public DbSet<HairCream> HairCreams { get; set; }
        public DbSet<TIRAH> TIRAHS { get; set; }
        public DbSet<WomenShooese> WomenShooeses { get; set; }
        public DbSet<HomeAccessories> HomeAccessorieses { get; set; }
        public DbSet<Backs> Backses { get; set; }
        public DbSet<UnderWear> UnderWears { get; set; }
        public DbSet<ACCESSORIE> ACCESSORIES { get; set; }
        public DbSet<BeautyProduct> BeautyProducts { get; set; }
        public DbSet<IBAYAT_AND_FASATIN> IBAYAT_AND_FASATINS { get; set; }
        public DbSet<CHILD> CHILDS { get; set; }
        public DbSet<MAN> MANS { get; set; }
    }
}
