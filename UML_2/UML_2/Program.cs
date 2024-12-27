using System;
using System.Collections.Generic;

namespace UML_2
{
    interface IIdentifiable
    {
        Guid Id { get; }
    }

    interface IExperienced
    {
        void TrainPet();
    }

    class Vaccine
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    class PetInformation
    {
        public List<string> Traits { get; set; } = new List<string>();
        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
    }

    class Animal
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public bool Carnivore { get; set; }
    }

    class Owner : IExperienced
    {
        public string Name { get; set; }

        public void TrainPet()
        {
            Console.WriteLine($"{Name} is training their pet.");
        }
    }

    class Pet : IIdentifiable
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public void Feed()
        {
            if (IsHerbivore())
            {
                Console.WriteLine($"{Name} is eating plants.");
            }
            else
            {
                Console.WriteLine($"{Name} is eating meat.");
            }
        }

        public bool IsHerbivore()
        {
            return !Type.Carnivore;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner { Name = "Ali Yılmaz" };

            Animal animal = new Animal
            {
                Type = "Kedi",
                Breed = "Van Kedisi",
                Carnivore = true
            };

            PetInformation petInfo = new PetInformation();
            petInfo.Traits.Add("Sevecen");
            petInfo.Traits.Add("Enerjik");
            petInfo.Vaccines.Add(new Vaccine { Name = "Kuduz Aşısı", Type = "Koruyucu" });

            Pet pet = new Pet
            {
                Name = "Mırmır",
                Age = 2,
                Owner = owner,
                Type = animal,
                PetInfo = petInfo
            };

            Console.WriteLine($"Evcil Hayvan Adı: {pet.Name}");
            Console.WriteLine($"Yaşı: {pet.Age}");
            Console.WriteLine($"Sahibi: {pet.Owner.Name}");
            Console.WriteLine($"Türü: {pet.Type.Type}, Irkı: {pet.Type.Breed}");
            Console.WriteLine($"Otçul mu: {pet.IsHerbivore()}");

            Console.WriteLine("\nÖzellikleri:");
            foreach (var trait in pet.PetInfo.Traits)
            {
                Console.WriteLine($"- {trait}");
            }

            Console.WriteLine("\nAşıları:");
            foreach (var vaccine in pet.PetInfo.Vaccines)
            {
                Console.WriteLine($"- {vaccine.Name} ({vaccine.Type})");
            }

            pet.Feed();
            owner.TrainPet();

            Console.ReadLine();
        }
    }
}
