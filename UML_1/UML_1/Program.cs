using System;

namespace UML_1
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        private bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && PostalCode > 0;
        }

        public string OutputAsLabel()
        {
            if (Validate())
            {
                return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
            }
            else
            {
                return "Invalid Address";
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public Address LivesAt { get; set; }

        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} purchased a parking pass.");
        }
    }

    class Student : Person
    {
        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }

        public bool IsEligibleToEnroll(string courseName)
        {
            return AverageMark >= 50;
        }

        public int GetSeminarsTaken()
        {
            return new Random().Next(0, 10); // Örnek olarak rastgele değer döndürüyorum.
        }
    }

    class Professor : Person
    {
        public int Salary { get; private set; }
        protected int StaffNumber { get; set; }
        private int YearsOfService { get; set; }
        public int NumberOfClasses { get; set; }

        public Professor(int salary, int staffNumber, int yearsOfService, int numberOfClasses)
        {
            Salary = salary;
            StaffNumber = staffNumber;
            YearsOfService = yearsOfService;
            NumberOfClasses = numberOfClasses;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Street = "Gazi",
                City = "Atatürk",
                State = "good",
                PostalCode = 23000,
                Country = "Türkiye"
            };

            Student student = new Student
            {
                Name = "Tuğkan",
                PhoneNumber = "0666 999 88 77",
                EmailAddress = "tugkan23@example.com",
                LivesAt = address,
                StudentNumber = 12345,
                AverageMark = 74
            };

            Professor professor = new Professor(75000, 54321, 10, 4)
            {
                Name = "Dr.Mert",
                PhoneNumber = "0333 444 55 66",
                EmailAddress = "dr.mertyılmaz06@example.com",
                LivesAt = address
            };

            Console.WriteLine($"{student.Name} lives at: {student.LivesAt.OutputAsLabel()}");
            Console.WriteLine($"{professor.Name} teaches {professor.NumberOfClasses} classes.");

            student.PurchaseParkingPass();
            professor.PurchaseParkingPass();

            Console.WriteLine($"Is {student.Name} eligible to enroll? {student.IsEligibleToEnroll("Math 101")}");
            Console.WriteLine($"{student.Name} has taken {student.GetSeminarsTaken()} seminars.");

            Console.ReadLine();
        }
    }
}
