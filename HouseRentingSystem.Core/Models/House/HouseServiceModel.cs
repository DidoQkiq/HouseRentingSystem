﻿using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem.Core.Constants.MessageConstants;


namespace HouseRentingSystem.Core.Models.House
{
    public class HouseServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseTitleMaxLength, MinimumLength = HouseTitleMinLength, ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseAddressMaxLength, MinimumLength = HouseAddressMinLength, ErrorMessage = LengthMessage)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name ="Image Url")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal), HousePriceMinimum, HousePriceMaximum, ErrorMessage = "Price per month must be a positive number and less than {2} leva")]
        [Display(Name ="Price per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name ="Is Rented")]
        public bool IsRented { get; set; }
    }
}