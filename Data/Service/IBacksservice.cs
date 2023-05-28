using S_TCHAD.Data.Base;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public interface IBacksservice : IEntityBaseReprository<Backs>
    {
        Task UpdateProductAsync(NewProductVM data);
    }
}
