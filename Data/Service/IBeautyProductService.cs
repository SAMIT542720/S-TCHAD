using S_TCHAD.Data.Base;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public interface IBeautyProductService : IEntityBaseReprository<BeautyProduct>
    {
        Task UpdateProductAsync(NewProductVM data);
    }
}
