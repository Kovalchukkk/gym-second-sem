using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class VisitorRepository : Repository<Visitor>
    {
        public override string ShowDiscount(int indx)
        {
            DateTime now = DateTime.Now;
            string currentdate = now.Day.ToString() + now.Month.ToString();
            double changedprice = 0;
            double discount = Visitor.DISCOUNT;
            if (data[indx].Birthday == currentdate)
            {
                changedprice += Convert.ToDouble(data[indx].Membership_price) * ((100 - discount) / 100);
                return "Happy Birthday! You received " + discount + "% discount!!! Now your gym membership price is " + changedprice;
            }
            else
                return "You don't have any discounts!";
        }

        public override void Show()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public override List<Visitor> GetAll()
        {
            return data;
        }
    }
}
