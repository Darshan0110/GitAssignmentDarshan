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
        public double CalculateDiscount(Customer customer, double purchaseAmount)
        {
            
                return customer.Membership.CalculateDiscount(purchaseAmount);

            }
        }

    }
    public class MembershipCostCalculator
    {
        public double CalculateMembershipCost(Customer customer, int months)
        {
            return customer.Membership.ClaculateMembershipCost(months);
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
