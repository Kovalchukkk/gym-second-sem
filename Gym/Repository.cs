using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class Repository<T> : IRepository<T> where T: IHuman
    {
        protected List<T> data;
        public Repository()
        {
            data = new List<T>();
        }

        public void Add(T item)
        {
            data.Add(item);            
        }

        public void Del(int indx)
        {   
            data.Remove(data[indx]);
        }

        public void Show()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
