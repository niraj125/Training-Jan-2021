﻿using Swiggy.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swiggy.Models.Repository
{
    public class RRestaurant : GenericRepository<Restaurant>, IRestaurant
    {
        public RRestaurant(Swiggy_ProjectContext context) : base(context)
        {

        }
    }
}
