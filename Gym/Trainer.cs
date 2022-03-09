using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class Trainer : IHuman
    {
        public Trainer(string name = "", int experience = 0, int id = 0)
        {
            this.Name = name;
            this.Experience = experience;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Trainer: {Name}\t\tExperience: {Experience}";
        }




        //auto property
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Id { get; set; }
    }
}
