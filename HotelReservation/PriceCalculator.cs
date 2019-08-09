using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class PriceCalculator
    {
        public decimal PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
        public Season ReservationSeason { get; set; }
        public DiscountType Discount { get; set; }

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season)
        {
            PricePerDay = pricePerDay;
            NumberOfDays = numberOfDays;
            ReservationSeason = season;
        }

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, DiscountType discount) : this(pricePerDay, numberOfDays,season)
        {
            Discount = discount;
        }

        public decimal CaclulatePrice()
        {
            decimal result = (PricePerDay * NumberOfDays)* (int)ReservationSeason;
            decimal discount = result * (int)Discount / 100;
            result = result - discount;
            return result;
        }

        public override string ToString()
        {
            return new string($"{this.CaclulatePrice():f2}");
        }
    }
}
