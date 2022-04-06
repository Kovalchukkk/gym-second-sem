using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym
{
    public class Visitor : IHuman
    {
        public const double DISCOUNT = 20;
        public Visitor(string name = "", string country = "", string membership_card = "", string birthday = "", string personal_trainer = "", int trainer_id = 0)
        {
            this.Name = name;
            this.Country = country;
            this.Membership_card = membership_card;
            this.Birthday = birthday;
            this.Personal_trainer = personal_trainer;
            this.Trainer_id = trainer_id;
            SetMembership_price(membership_card);
        }

        public override string ToString()
        {
            return $"Visitor: {Name}\t\tCountry: {Country}\t\tMembership card: {Membership_card}\t\tTrainer: {Personal_trainer} Trainer id: {Trainer_id}";
        }
        
        //auto property
        public string Name { get; set; }
        public string Country { get; set; }
        public string Membership_card { get; set; }
        public string Birthday { get; set; }
        public string Personal_trainer { get; set; }
        public int Trainer_id { get; set; }
        public int Membership_price { get; set; }

        private void SetMembership_price(string value)
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
