using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class VisitorRepository : Repository<Visitor>, IVisitorRepository
    {
        public void ShowDiscount(int indx)
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

        public void ShowTheMostPopularTrainer()
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
    }
}
