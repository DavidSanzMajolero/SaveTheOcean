using System;

namespace SaveTheOcean
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public string NumberRescue { get; set; }
        public string RescueDate { get; set; }
        public string Location { get; set; }
        public int AffectionDegree { get; set; }

        private static readonly Random random = new Random();

        public Animal(string name, string species, double weight, string rescueDate, string location)
        {
            Name = name;
            Species = species;
            Weight = weight;
            RescueDate = rescueDate;
            Location = location;
            AffectionDegree = GenerateRandomAffectionDegree();
            NumberRescue = GenerateRescueNumber();
        }

        protected abstract int GenerateRandomAffectionDegree();

        public static string GenerateRescueNumber()
        {
            return "RES" + random.Next(1000).ToString();
        }
    }
}
