using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean
{
    public class Tortoise : Animal
    {
        public Tortoise(string name, string species, double weight, string rescueDate, string location) : base(name, species, weight, rescueDate, location) { }
        protected override int GenerateRandomAffectionDegree()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }

}
