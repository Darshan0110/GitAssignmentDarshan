using System;
using System.Collections.Generic;

namespace OCPExample
{
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
    
    public abstract class Membership
{
    public string Name { get; protected set; }
    
    public abstract double CalculateDiscount(double purchaseAmount);
    public abstract double CalculateMembershipCost(int months);
}
    public class Customer
    {
        public string Name { get; set; }
        public string MembershipType { get; set; }

        public Customer(string name, string membershipType)
        {
            Name = name;
            MembershipType = membershipType;
        }
    }

    public class DiscountCalculator
    {
        public double CalculateDiscount(Customer customer)
        {
            if (customer.MembershipType == "Regular")
            {
                return 0.05; // 5% discount
            }
            else if (customer.MembershipType == "Premium")
            {
                return 0.10; // 10% discount
            }
            else if (customer.MembershipType == "VIP")
            {
                return 0.20; // 20% discount
            }
            else
            {
                return 0.00; // No discount
            }
        }

    }
    public class MembershipCostCalculator
    {
        public double CalculateMembership(Customer customer, int months)
        {
            if (customer.MembershipType == "Regular")
            {
                return 400 * months;
            }
            else if (customer.MembershipType == "Premium")
            {
                return months < 12 ? 600 * months : (500 * months) + 200;
            }
            else if (customer.MembershipType == "VIP")
            {
                return months < 18 ? 900 * months : (550 * months) + 300;
            }
            else
            {
                return 0.00; // What Now? Is this even right?
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            var customers = new List<Customer>
            {
                new Customer("Alice", "Regular"),
                new Customer("Bob", "Premium"),
                new Customer("Cathy", "VIP")
            };

            var discountCalculator = new DiscountCalculator();

            foreach (var c in customers)
            {
                double discount = discountCalculator.CalculateDiscount(c);
                Console.WriteLine($"{c.Name} ({c.MembershipType}) gets {discount * 100}% discount.");
            }

            var membershipCalculator = new MembershipCostCalculator();

            foreach (var c in customers)
            {
                double membershipCost = membershipCalculator.MembershipCostCalculator(c, 12);
                Console.WriteLine($"{c.Name} ({c.MembershipType}) for 12 months costs {membershipCost}.");

                membershipCost = membershipCalculator.MembershipCostCalculator(c, 18);
                Console.WriteLine($"{c.Name} ({c.MembershipType}) for 18 months costs {membershipCost}.");

                membershipCost = membershipCalculator.MembershipCostCalculator(c, 24);
                Console.WriteLine($"{c.Name} ({c.MembershipType}) for 24 months costs {membershipCost}.");
            }
        }
    }
}
