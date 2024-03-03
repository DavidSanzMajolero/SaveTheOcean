using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean
{
    public class Technician : Person
    {

        public Technician(string name, int experiencie) : base(name, experiencie)  { }

        public override void UpdateExperience(int value)
        {
            Experience += value;
        }
    }

}
