using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Updated();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Updated();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Enes Emre";
            customer.EfirstName= "Enes Emre";
            customer.LastName = "Tuglu";

            Customer customer2 = new Customer
            {
                City = "Istanbul",
                Id=2,
                LastName="Tuglu",
                FirstName="Kerem",
                EfirstName="Kerem"
            };
            Console.WriteLine(customer2.FirstName);
            
            Console.ReadLine();
        }
    }
}

