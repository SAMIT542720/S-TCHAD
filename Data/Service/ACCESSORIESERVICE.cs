﻿using S_TCHAD.Data.Base;
using S_TCHAD.Models;

namespace S_TCHAD.Data.Service
{
    public class ACCESSORIESERVICE : EntityBaseRepository<ACCESSORIE>, IACCESSORIESERVICE
    {
        public ACCESSORIESERVICE(AppDbContext context) : base(context) { }
    }
}