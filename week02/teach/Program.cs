using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Customer Service Demo ===");
        var service = new CustomerServiceSolution(2);

        service.AddNewCustomer(new Customer("Alice", "A001", "Billing issue"));
        service.AddNewCustomer(new Customer("Bob", "B002", "Password reset"));
        service.AddNewCustomer(new Customer("Carol", "C003", "Cannot login")); // Should show full error

        service.ServeCustomer();
        service.ServeCustomer();
        service.ServeCustomer(); // Should show empty error
    }
}
