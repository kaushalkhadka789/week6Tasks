using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== TASK 1: Expression Bodied Members =====");
        Rectangle rect = new Rectangle(10, 5);
        Console.WriteLine($"Area: {rect.Area}");
        Console.WriteLine($"Perimeter: {rect.Perimeter}");
        Console.WriteLine();

        Console.WriteLine("===== TASK 2: Custom Delegates =====");

        // task2 Add/Subtract
        Calculate calc;

        calc = DiscountMethods.Add;
        Console.WriteLine($"Add: {calc(10, 5)}");

        calc = DiscountMethods.Subtract;
        Console.WriteLine($"Subtract: {calc(10, 5)}");

        // task2 — Discount Strategy
        double price = 1000;

        Console.WriteLine($"Festival Discount: {DiscountMethods.CalculateFinalPrice(price, DiscountMethods.FestivalDiscount)}");
        Console.WriteLine($"Seasonal Discount: {DiscountMethods.CalculateFinalPrice(price, DiscountMethods.SeasonalDiscount)}");
        Console.WriteLine($"No Discount: {DiscountMethods.CalculateFinalPrice(price, DiscountMethods.NoDiscount)}");

        // task2 — Lambda 30% discount
        double lambdaDiscount = DiscountMethods.CalculateFinalPrice(price, p => p * 0.70);
        Console.WriteLine($"Lambda 30% Discount: {lambdaDiscount}");
        Console.WriteLine();
    }
}