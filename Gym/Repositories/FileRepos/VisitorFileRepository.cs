using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // for StreamWriter and StreamReader
namespace Gym
{
    public class VisitorFileRepository : FileRepository<Visitor>
    {
        public VisitorFileRepository(string filename = @"D:\Навчальна практика 2 курс\gym-second-sem\Gym\Files\visitors.txt")
            : base(filename)
        {
            ReadFromFile();
        }

        public override void WriteToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        sw.WriteLine($"{data[i].Name},{data[i].Country},{data[i].Membership_card},{data[i].Birthday},{data[i].Personal_trainer},{data[i].Trainer_id}");
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
                    string name, country, membership_card, birthday, personal_trainer, trainer_id_temp;
                    int trainer_id;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var arr = line.Split(',');
                        name = arr[0];
                        country = arr[1];
                        membership_card = arr[2];
                        birthday = arr[3];
                        personal_trainer = arr[4];
                        trainer_id_temp = arr[5];
                        trainer_id = int.Parse(trainer_id_temp);
                        data.Add(new Visitor(name, country, membership_card, birthday, personal_trainer, trainer_id));
                    }

                    Sync = prevSync;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }


        public override void ShowDiscount(int indx)
        {
            DateTime now = DateTime.Now;
            string currentdate = now.Day.ToString() + now.Month.ToString();
            double changedprice = 0;
            double discount = Visitor.DISCOUNT;
            if (data[indx].Birthday == currentdate)
            {
                changedprice += Convert.ToDouble(data[indx].Membership_price) * ((100 - discount) / 100);
                Console.WriteLine("Happy Birthday! You received " + discount + "% discount!!! Now your gym membership price is " + changedprice);
            }
            else
                Console.WriteLine("You don't have any discounts!");
        }

        public override void ShowTheMostPopularTrainer()
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

            Console.WriteLine("The most popular trainer: " + data[res].Personal_trainer);
        }

        private string InitializeArray()
        {
            string temp = "";

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

        public override void Show()
        {
            SyncRead();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
