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

        // Task3
        Console.WriteLine("===== TASK 3: Built-in Delegate (Func) =====");
        int[] nums = { 1, 5, 12, 16, 3, 8 };

        Console.WriteLine("Even numbers:");
        NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("Greater than 10:");
        NumberProcessor.ProcessNumbers(nums, n => n > 10);
        Console.WriteLine();

        // Task4
        Console.WriteLine("===== TASK 4: LINQ Basics =====");

        // 4.1  It is about the Square numbers
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        var squared = list.Select(n => n * n);
        Console.WriteLine("Squared: " + string.Join(", ", squared));

        // 4.2 Book price filter
        List<Book> books = new List<Book>
        {
            new Book { Name="Book A", Price=500 },
            new Book { Name="Book B", Price=1500 },
            new Book { Name="Book C", Price=2000 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000);
        Console.WriteLine("Premium Books:");
        foreach (var b in premiumBooks)
            Console.WriteLine(b.Name);

        // 4.3 Student sorting
        List<Student> students = new List<Student>
        {
            new Student{Name="Ram"},
            new Student{Name="Asha"},
            new Student{Name="Binod"},
        };

        var sortedStudents = students.OrderBy(s => s.Name);
        Console.WriteLine("Sorted Students:");
        foreach (var s in sortedStudents)
            Console.WriteLine(s.Name);

        Console.WriteLine();

        // Task5
        Console.WriteLine("===== TASK 5: LINQ Continued =====");

        // 5.1 Aggregation
        List<CashierSales> sales = new List<CashierSales>
        {
            new CashierSales{CashierName="A", Sales=5000},
            new CashierSales{CashierName="B", Sales=7000},
            new CashierSales{CashierName="C", Sales=9000},
        };

        Console.WriteLine($"Total Cashiers: {sales.Count}");
        Console.WriteLine($"Total Sales: {sales.Sum(s => s.Sales)}");
        Console.WriteLine($"Highest Sale: {sales.Max(s => s.Sales)}");
        Console.WriteLine($"Lowest Sale: {sales.Min(s => s.Sales)}");
        Console.WriteLine($"Average Sale: {sales.Average(s => s.Sales)}");

        // 5.2 Applicants
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant{Name="Rita", Age=17},
            new Applicant{Name="Hari", Age=20},
            new Applicant{Name="Sam", Age=15},
        };

        Console.WriteLine("Any applicant under 18: " + applicants.Any(a => a.Age < 18));
        Console.WriteLine("All applicants above 16: " + applicants.All(a => a.Age > 16));

        // 5.3 Music
        List<Music> tracks = new List<Music>
        {
            new Music{Title="Song1", DurationSec=150},
            new Music{Title="Song2", DurationSec=300},
            new Music{Title="Song3", DurationSec=700},
        };

        Console.WriteLine("First Song: " + tracks.First().Title);
        Console.WriteLine("Last Song: " + tracks.Last().Title);
        Console.WriteLine("First >4 min: " + tracks.First(t => t.DurationSec > 240).Title);

        var safeResult = tracks.FirstOrDefault(t => t.DurationSec > 600);
        Console.WriteLine("First >10 min (safe): " + (safeResult?.Title ?? "None"));
        Console.WriteLine();


    }
}