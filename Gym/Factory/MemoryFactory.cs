using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class MemoryFactory : IFactory
    {
        public Repository<Visitor> GetVisitorRepository()
        {
            return new VisitorRepository();
        }
        public Repository<Trainer> GetTrainerRepository()
        {
            return new TrainerRepository();
        }
    }
}
