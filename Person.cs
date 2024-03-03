using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean
{

    public abstract class Person
    {
        public string Name { get; set; }
        public int Experience { get;  set; }

        public Person(string name, int experiencie)
        {
            Name = name;
            Experience = experiencie;
        }
        public virtual void UpdateExperience(int value)
        {
            Experience += value;
        }
    }
}
