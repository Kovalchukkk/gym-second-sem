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
            if (data[indx].Birthday == currentdate)
            {
                changedprice += Convert.ToDouble(data[indx].Membership_price) * data[indx].Discount;
                Console.WriteLine("Happy Birthday! You received 20% discount!!! Now your gym membership price is " + changedprice);
            }
            else
                Console.WriteLine("You don't have any discounts!");
        }

        public void ShowTheMostPopularTrainer()
        {
            //TODO
            
        }
    }
}
