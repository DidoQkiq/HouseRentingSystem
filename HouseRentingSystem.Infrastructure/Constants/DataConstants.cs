﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int CategoryNameMaxLength = 50;

        public const int AgentPhoneNumberMaxLength = 15;
        public const int AgentPhoneNumberMinLength = 7;

        public const int HouseTitleMaxLength = 50;
        public const int HouseTitleMinLength = 10;


        public const int HouseAddressMaxLength = 150;
        public const int HouseAddressMinLength = 30;


        public const int HouseDescriptionMaxLength = 500;
        public const int HouseDescriptionMinLength = 50;

        public const string HousePriceMinimum = "0.00";
        public const string HousePriceMaximum = "2000.00";

    }
}
