using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            // Danger of affecting due to change in Customer class
            this.CalculateRating(excludeOrders: true);
        }
    }
}
