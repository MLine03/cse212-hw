using System;
using System.Collections.Generic;

public class CustomerServiceSolution
{
    private readonly Queue<Customer> queue;
    private readonly int maxSize;

    public CustomerServiceSolution(int size)
    {
        maxSize = size > 0 ? size : 10;
        queue = new Queue<Customer>();
    }

    public void AddNewCustomer(Customer customer)
    {
        if (queue.Count >= maxSize)
        {
            Console.WriteLine("Error: Customer queue is full. Cannot add new customer.");
        }
        else
        {
            queue.Enqueue(customer);
            Console.WriteLine($"Customer added: {customer.Name}");
        }
    }

    public void ServeCustomer()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Error: No customers in the queue.");
        }
        else
        {
            var customer = queue.Dequeue();
            Console.WriteLine("Now serving:");
            Console.WriteLine(customer.ToString());
        }
    }
}
