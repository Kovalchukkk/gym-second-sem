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
            int index = 0;
            int max = data[0].Experience;

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Experience > max)
                {
                    max = data[i].Experience;
                    index = i;
                }
            }

            Console.WriteLine("The most experienced trainer is " + data[index].Name);
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
            item += data[indx];   
        }
    }
}
