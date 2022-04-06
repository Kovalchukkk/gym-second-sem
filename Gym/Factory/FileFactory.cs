using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class FileFactory : IFactory
    {
        public Repository<Visitor> GetVisitorRepository()
        {
            return new VisitorFileRepository();
        }

        public Repository<Trainer> GetTrainerRepository()
        {
            return new TrainerFileRepository();
        }
    }
}
