using System;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine(customer.Name);
        }
    }

    public class Customer
    {
        public string Name { get; } = "Chris";
    }
}
