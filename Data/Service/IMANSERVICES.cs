﻿using S_TCHAD.Data.Base;
using S_TCHAD.Data.VIEWMODELS;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public interface IMANSERVICES : IEntityBaseReprository<ACCESSORIE>
    {
        Task UpdateProductAsync(NewProductVM data);
    }
}
