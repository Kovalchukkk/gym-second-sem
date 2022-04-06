using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public interface IFactory
    {
        Repository<Visitor> GetVisitorRepository();
        Repository<Trainer> GetTrainerRepository();
    }
}
