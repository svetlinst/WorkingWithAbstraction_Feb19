using System;

namespace HotelReservation
{
    class StartUp

    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (input.Length ==4)
            {
                var priceCalcaulator = new PriceCalculator
                    (
                        decimal.Parse(input[0]),
                        int.Parse(input[1]),
                        (Season)Enum.Parse(typeof(Season), input[2]),
                        (DiscountType)Enum.Parse(typeof(DiscountType), input[3])
                    );
                Console.WriteLine(priceCalcaulator.ToString());

            }
            else
            {
                var priceCalcaulator = new PriceCalculator
                (
                    decimal.Parse(input[0]),
                    int.Parse(input[1]),
                    (Season)Enum.Parse(typeof(Season), input[2])
                );
                Console.WriteLine(priceCalcaulator.ToString());
            }
            

        }

    }
}
