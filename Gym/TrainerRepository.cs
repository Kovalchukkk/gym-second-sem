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

        public void SetTrainer(Visitor item, int indx = 0)
        {
            try
            {
                item += data[indx];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("We can't find this trainer in the list!");
            }
               
        }
    }
}
