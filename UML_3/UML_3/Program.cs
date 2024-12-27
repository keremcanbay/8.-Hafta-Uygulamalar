using System;
using System.Collections.Generic;

namespace UML_3
{
    class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }

        public void Update()
        {
            Console.WriteLine($"Transaction {Id} has been updated.");
        }
    }

    class Reservation
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string List { get; set; }

        public void Confirmation()
        {
            Console.WriteLine($"Reservation {Id} confirmed with details: {Details}");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Payment { get; set; }

        public void Update()
        {
            Console.WriteLine($"Customer {Name} has been updated.");
        }
    }

    class Car
    {
        public int Id { get; set; }
        public int Details { get; set; }
        public string OrderType { get; set; }

        public void ProcessDebit()
        {
            Console.WriteLine($"Debit processed for Car {Id}.");
        }
    }

    class RentingOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string ContactNum { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public void VerifyAccount()
        {
            Console.WriteLine($"Account for {Name} has been verified.");
        }
    }

    class Payment
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string Amount { get; set; }

        public void Add()
        {
            Console.WriteLine($"Payment of {Amount} has been added.");
        }

        public void Update()
        {
            Console.WriteLine($"Payment {Id} has been updated.");
        }
    }

    class Rentals
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Price { get; set; }

        public void Add()
        {
            Console.WriteLine($"Rental {Names} has been added.");
        }

        public void Update()
        {
            Console.WriteLine($"Rental {Id} has been updated.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Ahmet Yılmaz",
                Contact = "05551234567",
                Address = "İstanbul",
                Payment = 500
            };

            Car car = new Car
            {
                Id = 101,
                Details = 2022,
                OrderType = "SUV"
            };

            RentingOwner owner = new RentingOwner
            {
                Id = 1,
                Name = "Mehmet Kaya",
                Age = "40",
                ContactNum = "05331234567"
            };

            Reservation reservation = new Reservation
            {
                Id = 1,
                Details = "Car rental for 2 days",
                List = "Car, Insurance"
            };

            Payment payment = new Payment
            {
                Id = 1,
                CardNumber = 12345678,
                Amount = "500 TL"
            };

            Rentals rentals = new Rentals
            {
                Id = 1,
                Names = "Car Rental",
                Price = "500 TL"
            };

            Transaction transaction = new Transaction
            {
                Id = 1,
                Name = "Car Rental Transaction",
                Date = "27/12/2024",
                Address = "İstanbul"
            };

            customer.Update();
            car.ProcessDebit();
            owner.VerifyAccount();
            reservation.Confirmation();
            payment.Add();
            rentals.Add();
            transaction.Update();

            Console.ReadLine();
        }
    }
}
