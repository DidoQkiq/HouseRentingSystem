﻿using HouseRentingSystem.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Contracts.House
{
    public interface IHouseService
    {
        public Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();
    }
}
