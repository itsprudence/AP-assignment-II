using System;

namespace ProfitLossApp
{
    // The Business class encapsulates the cost and revenue data for one item.
    class Business
    {
        // Fields to hold the buying price, transport cost, and selling price.
        private decimal buyingPrice;
        private decimal transportCost;
        private decimal sellingPrice;

        // Default constructor: initializes all values to 0.
        public Business()
        {
            buyingPrice = 0m;
            transportCost = 0m;
            sellingPrice = 0m;
        }

        // Parameterized constructor: sets fields to the given values.
        public Business(decimal buyingPrice, decimal transportCost, decimal sellingPrice)
        {
            this.buyingPrice = buyingPrice;
            this.transportCost = transportCost;
            this.sellingPrice = sellingPrice;
        }

        // Method to compute and display profit or loss.
        public void ComputeResult()
        {
            // Total cost is the sum of buying price and transport cost.
            decimal totalCost = buyingPrice + transportCost;

            // Difference between what you sold it for and what it cost you.
            decimal diff = sellingPrice - totalCost;

            if (diff > 0)
            {
                Console.WriteLine($"Profit made: {diff:C}");
            }
            else if (diff < 0)
            {
                Console.WriteLine($"Loss incurred: {Math.Abs(diff):C}");
            }
            else
            {
                Console.WriteLine("No profit, no loss (break-even).");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter buying price:");
            decimal bp = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter transport cost:");
            decimal tc = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter selling price:");
            decimal sp = decimal.Parse(Console.ReadLine());

            // Create a Business object using the parameterized constructor.
            Business b = new Business(bp, tc, sp);

            // Compute and display profit or loss.
            b.ComputeResult();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
