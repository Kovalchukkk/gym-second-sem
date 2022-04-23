using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public abstract class Repository<T> where T: IHuman //base class
    {
        public List<T> data { get; set; } = new List<T>();
        

        public virtual void Add(T item)
        {
            data.Add(item);            
        }

        public abstract List<T> GetAll();

        public virtual void Del(int indx)
        {   
            data.Remove(data[indx]);
        }

        public abstract void Show();

        public virtual string MaxTrainer() { return "";}
        public virtual void SetId() { }
        public virtual void SetTrainer(Visitor item, int indx = 0) { }
        public virtual string ShowDiscount(int indx) { return ""; }
        


    }
}
