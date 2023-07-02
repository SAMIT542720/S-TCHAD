using S_TCHAD.Data.Base;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public interface ICHILDSERVICE : IEntityBaseReprository<CHILD>
    {
        Task UpdateProductAsync(NewProductVM data);
    }
}
