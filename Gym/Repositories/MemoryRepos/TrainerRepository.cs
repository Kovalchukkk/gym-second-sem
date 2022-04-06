using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class TrainerRepository : Repository<Trainer>
    {
        public override string MaxTrainer()
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

            return data[index].Name;
        }

        public override void SetId()
        {
            for (int i = 0; i < data.Count; i++)
            {
                data[i].Id = i;
            }
        }

        public override void SetTrainer(Visitor item, int indx = 0)
        {
            item += data[indx];   
        }

        public override void Show()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
