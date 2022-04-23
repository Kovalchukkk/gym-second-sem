using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // for StreamWriter and StreamReader
namespace Gym
{
    public class TrainerFileRepository : FileRepository<Trainer>
    {
        public TrainerFileRepository(string filename = @"D:\Навчальна практика 2 курс\gym-second-sem\Gym\Files\trainers.txt")
            : base(filename)
        {
            ReadFromFile();
        }

        public override void WriteToFile()
        {
            SetId();
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        sw.WriteLine($"{data[i].Name},{data[i].Experience},{data[i].Id}");
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public override void ReadFromFile()
        {
            bool prevSync = Sync;
            Sync = false;
            try
            {
                using (StreamReader sr = new StreamReader(FileName, Encoding.Default))
                {
                    string line;
                    string name, experience_temp, id_temp;
                    int experience, id;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var arr = line.Split(',');
                        name = arr[0];
                        experience_temp = arr[1];
                        id_temp = arr[2];
                        experience = int.Parse(experience_temp);
                        id = int.Parse(id_temp);
                        data.Add(new Trainer(name, experience, id));
                    }

                    Sync = prevSync;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

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
            SyncRead();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public override List<Trainer> GetAll()
        {
            return data;
        }
    }
}
