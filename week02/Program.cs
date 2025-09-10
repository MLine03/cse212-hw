using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== CustomerServiceSolution Demo ===");

        var service = new CustomerServiceSolution(2);

        service.AddNewCustomer(new Customer("Alice", "A001", "Billing issue"));
        service.AddNewCustomer(new Customer("Bob", "B002", "Password reset"));
        service.AddNewCustomer(new Customer("Carol", "C003", "Cannot login")); // Should trigger "full" error

        service.ServeCustomer();
        service.ServeCustomer();
        service.ServeCustomer(); // Should trigger "empty" error
    }
}
