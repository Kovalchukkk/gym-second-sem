using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class Visitor : IHuman
    {
        public Visitor(string name = "", string birthday = "", string country = "", string membership_card = "", string personal_trainer = "", int trainer_id = 0, double discount = 0.8)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Country = country;
            this.Personal_trainer = personal_trainer;
            this.Membership_card = membership_card;
            this.Trainer_id = trainer_id;
            this.Discount = discount;
        }

        public override string ToString()
        {
            if (Personal_trainer != "")
                return $"Visitor: {Name}\t\tCountry: {Country}\t\tMembership card: {Membership_card}\t\tTrainer: {Personal_trainer} Trainer id: {Trainer_id}";
            else
                return $"Visitor: {Name}\t\tCountry: {Country}\t\tMembership card: {Membership_card}";
        }
        
        //auto property
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Country { get; set; }
        public string Personal_trainer { get; set; }
        public string Membership_card { get; set; }
        public int Trainer_id { get; set; }
        public int Membership_price { get; set; }
        public double Discount { get; set; }

        public void SetMembership_price(string value)
        {
            switch (value)
            {
                case "beginner":
                    this.Membership_price = 500;
                    break;
                case "average":
                    this.Membership_price = 800;
                    break;
                case "professional":
                    this.Membership_price = 2000;
                    break;
                default:
                    this.Membership_price = 0;
                    break;

            }
            
        }

        //override operator "+"
        public static Visitor operator + (Visitor visitor, Trainer trainer)
        {
            visitor.Personal_trainer = trainer.Name;
            visitor.Trainer_id = trainer.Id;
            return visitor;
        }
    }
}
