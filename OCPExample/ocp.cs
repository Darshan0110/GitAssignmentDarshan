using System;
using System.Collections.Generic;

namespace OCPExample
{ 
    public abstract class Membership
    {
         public string Name { get; protected set; }
    
         public abstract double CalculateDiscount(double purchaseAmount);
         public abstract double CalculateMembershipCost(int months);
    }


    public class RegularMembership : Membership
    {
        public RegularMembership()
        {
            Name = "Regular";
        }

        public override double CalculateDiscount(double purchaseAmount)
        {
            return 0.05;
        }
 
        public override double CalculateMembershipCost(int months)
        {
            return 400 * months;
        }
    }

    public class PremiumMembership : Membership
    {
        public PremiumMembership()
        {
            Name = "Premium";
        }

        public override double CalculateDiscount(double purchaseAmount)
            {
            return 0.10;
        }

        public override double CalculateMembershipCost(int months)
        {
            return months < 12 ? 600 * months : (500 * months) + 200;
        }
    }

    public class VIPMembership : Membership
    {  
    
        public VIPMembership()
        {
            Name = "VIP";
        }

        public override double CalculateDiscount(double purchaseAmount)
        {
            return 0.20;
        }

        public override double CalculateMembershipCost(int months)
        {
            return months < 18 ? 900 * months : (550 * months) + 300;
        }
    }


    public class BasicMembership : Membership
    
    {
        public BasicMembership()
        {
            Name = "Basic";
        } 

        public override double CalculateDiscount(double purchaseAmount)
        {
            return purchaseAmount > 1000 ? 0.03 : 0.00;
        }

         public override double CalculateMembershipCost(int months)
        {
            return 200 * months;
        }
    }
    
    public class Customer
    {
        public string Name { get; set; }
        public Membership Membership { get; set; }

        public Customer(string name, Membership membership)
        {
            Name = name;
            Membership = membership;
        }
    }

    public class DiscountCalculator
    {
        public double CalculateDiscount(Customer customer , double purchaseAmount)
        {
            return customer.Membership.CalculateDiscount(purchaseAmount);
        }

    }
    public class MembershipCostCalculator
    {
        public double CalculateMembershipCost(Customer customer, int months)
        {
            return customer.Membership.CalculateMembershipCost(months);
        }
    }

    public class Program
    {
        public static void Main()
        {
            var customers = new List<Customer>
            {
                new Customer("Alice", new RegularMembership()),
                new Customer("Bob", new PremiumMembership()),
                new Customer("Cathy", new VIPMembership()),
                new Customer("John" , new BasicMembership())

            };

            var discountCalculator = new DiscountCalculator();

            Console.WriteLine("===DISCOUNTS===\n");

            foreach (var c in customers)
            {
                double discount500 = discountCalculator.CalculateDiscount(c, 500);
                Console.WriteLine($"{c.Name} ({c.Membership.Name}) with R500: {discount500 * 100}% discount.");

                double discount1500 = discountCalculator.CalculateDiscount(c, 1500);
                Console.WriteLine($"{c.Name} ({c.Membership.Name}) with R1500: {discount1500 * 100}% discount");
                Console.WriteLine();
            }

            Console.WriteLine("\n===MEMBERSHIP COSTS ===\n");

            var membershipCalculator = new MembershipCostCalculator();

            foreach (var c in customers)
            {
                double cost12 = membershipCalculator.CalculateMembershipCost(c, 12);
                Console.WriteLine($"{c.Name} ({c.Membership.Name}) 12 months: R{cost12}.");

                double cost18 = membershipCalculator.CalculateMembershipCost(c, 18);
                Console.WriteLine($"{c.Name} ({c.Membership.Name}) 18 months: R{cost18}.");

                double cost24 = membershipCalculator.CalculateMembershipCost(c, 24);
                Console.WriteLine($"{c.Name} ({c.Membership.Name}) 24 months: R{cost24}.");
                Console.WriteLine();
            }
        }
    }
}
