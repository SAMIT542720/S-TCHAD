using S_TCHAD.Data.Base;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public interface IWomenShooeseService : IEntityBaseReprository<WomenShooese>
    {
        Task UpdateProductAsync(NewProductVM data);
    }
}
