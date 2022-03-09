using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public interface ITrainerRepository
    {
        void MaxTrainer();
        void SetId();
        void SetTrainer(Visitor item, int indx = 0);
    }
}
