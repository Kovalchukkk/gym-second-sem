using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class TrainerRepository : Repository<Trainer>, ITrainerRepository
    {
        public void MaxTrainer()
        {

        }

        public void SetId()
        {
            for (int i = 0; i < data.Count; i++)
            {
                data[i].Id = i;
            }
        }
    }
}
