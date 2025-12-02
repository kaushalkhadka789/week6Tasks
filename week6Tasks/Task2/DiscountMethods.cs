using System;

public static class DiscountMethods
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;

    public static double FestivalDiscount(double price) => price * 0.80;
    public static double SeasonalDiscount(double price) => price * 0.90;
    public static double NoDiscount(double price) => price;

    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        => strategy(originalPrice);
}
