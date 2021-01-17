using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Yeni Müşteri Eklendi!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Müşteri ID : " + customer.Id);
            Console.WriteLine("Müşteri Adı : " + customer.FirstName);
            Console.WriteLine("Müşteri Soyadı : " + customer.LastName);
            Console.WriteLine("Müşteri Tc No : " + customer.TcNo);
            Console.WriteLine("----------------------------");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi..");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Müşteri ID : " + customer.Id);
            Console.WriteLine("Müşteri Adı : " + customer.FirstName);
            Console.WriteLine("Müşteri Soyadı : " + customer.LastName);
            Console.WriteLine("Müşteri Tc No : " + customer.TcNo);
            Console.WriteLine("----------------------------");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Müşteri ID : " + customer.Id);
            Console.WriteLine("Müşteri Adı : " + customer.FirstName);
            Console.WriteLine("Müşteri Soyadı : " + customer.LastName);
            Console.WriteLine("Müşteri Tc No : " + customer.TcNo);
        }
    }

}
