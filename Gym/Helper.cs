using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class Helper
    {
        public Repository<Visitor> visitorRepository;
        public Repository<Trainer> trainerRepository;

        public Helper()
        {
            var factory = FactoryCreator.GetFactory();
            visitorRepository = factory.GetVisitorRepository();
            trainerRepository = factory.GetTrainerRepository();
        }

        public string ShowTheMostPopularTrainer()
        {
            string[] m = InitializeArray().Split();
            Array.Sort(m);
            string maxWord = "", word = "";
            int maxCount = 0, count = 1, res = 0;

            foreach (string s in m)
            {
                if (s.Equals(word))
                {
                    count++;
                   
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxWord = word;
                    }
                    word = s;
                    count = 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxWord = word;
            }

            res = int.Parse(maxWord);

            var data = trainerRepository.data;
            return data[res].Name;
        }

        private string InitializeArray()
        {
            string temp = "";
            var data = visitorRepository.data;
            for (int i = 0; i < data.Count; i++)
            {
                if (i == data.Count - 1)
                {
                    temp += data[i].Trainer_id;
                }
                else
                {
                    temp += data[i].Trainer_id + " ";
                }
            }

            return temp;
        }

    }
}
