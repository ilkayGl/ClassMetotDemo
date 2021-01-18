using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1, customer2, customer3;
            Musteriler(out customer1, out customer2, out customer3);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Remove(customer3);

            Console.WriteLine("Müşteriler Listelendi!");

            Customer[] customers = { customer1, customer2, customer3 };
            foreach (var c in customers)
            {
                customerManager.CustomerList(c);
            }
        }

        private static void Musteriler(out Customer customer1, out Customer customer2, out Customer customer3)
        {
            customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "İlkay";
            customer1.LastName = "gl";
            customer1.TcNo = "123456789";

            customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Gizem";
            customer2.LastName = "Dek";
            customer2.TcNo = "13567984";

            customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ahmet";
            customer3.LastName = "gl";
            customer3.TcNo = "123456789";
        }
    }
}
