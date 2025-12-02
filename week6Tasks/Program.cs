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
    }
}