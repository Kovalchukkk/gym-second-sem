//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Gym
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            TestVisitorRepository();
//            //string[] m = "0 1 1 1 2 0 1 0 4 1 1 3 1 0".Split();
//            //Array.Sort(m);
//            ////foreach (string item in m)
//            ////{
//            ////    Console.WriteLine(item);
//            ////}

//            //string maxWord = "", word = "";
//            //int maxCount = 0, count = 1;

//            //foreach (string s in m)
//            //{
//            //    if (s.Equals(word))
//            //    {
//            //        count++;
//            //    }
//            //    else
//            //    {
//            //        if (count > maxCount)
//            //        {
//            //            maxCount = count;
//            //            maxWord = word;
//            //        }
//            //        word = s;
//            //        count = 1;
//            //    }
//            //}

//            //if (count > maxCount)
//            //{
//            //    maxCount = count;
//            //    maxWord = word;
//            //}

//            //Console.WriteLine(maxWord);

//            //Visitor first = new Visitor
//            //{
//            //    Name = "Mykola",
//            //    Birthday = "1107",
//            //    Country = "Ukraine",
//            //    Personal_trainer = "",
//            //    Membership_card = "beginner"
//            //};

//            //Trainer second = new Trainer
//            //{
//            //    Name = "Daryna",
//            //    Experience = 10
//            //};
//            //first += second;

//            //Console.WriteLine(first);
//            //Console.WriteLine(second);
//        }

//        static void TestVisitorRepository()
//        {
//            //var trainerRepository = new TrainerRepository();
//            //var item1 = new Trainer();
//            //item1.Name = "Oksana";
//            //item1.Experience = 5;
//            //var item2 = new Trainer();
//            //item2.Name = "Oksana";
//            //item2.Experience = 5;
//            //trainerRepository.Add(item1);
//            //trainerRepository.Add(item2);
//            //trainerRepository.SetId();
//            //trainerRepository.Show();
//            //Console.WriteLine(item1.Id);
//            //Console.WriteLine(item2.Id);

//            //var visitorRepository = new VisitorRepository();
//            //var item = new Visitor();
//            //item.Name = "Mykola ";
//            //item.Birthday = "63";
//            //item.Country = "Ukraine";
//            //item.Personal_trainer = "Daryna";
//            //item.Membership_card = "professional";
//            //item.SetMembership_price(item.Membership_card);

//            //visitorRepository.Add(item);

//            //visitorRepository.Show();
//            //visitorRepository.ShowDiscount(0);

//            //var visitorRepository = new Repository<Visitor>();
//            //for (int i = 1; i <= 6; i++)
//            //    visitorRepository.Add(new Visitor
//            //    {
//            //        Name = "Mykola " + i,
//            //        Birthday = "1107",
//            //        Country = "Ukraine",
//            //        Personal_trainer = "",
//            //        Membership_card = "beginner"

//            //    });
//            //visitorRepository.Del(2);
//            //visitorRepository.Show();

//        }

//    }
//}
