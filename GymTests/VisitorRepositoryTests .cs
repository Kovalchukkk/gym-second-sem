using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gym;
using System.Collections.Generic;

namespace GymTests
{
    [TestClass]
    public class VisitorRepositoryTests
    {
        
        [TestMethod]
        public void TestDeleteVisitorByNegIndex_ThrowException()
        {
            Repository<Visitor> visitorRepository;
            //var factory = FactoryCreator.GetFactory();
            visitorRepository = new VisitorRepository();
            Assert.ThrowsException<Exception>(() => visitorRepository.Del(-1));
        }

        [TestMethod]
        public void TestAddVisitor()
        {
            Repository<Visitor> visitorRepository;
            //var factory = FactoryCreator.GetFactory();
            visitorRepository = new VisitorRepository();
            Visitor visitor = new Visitor("Maksym", "Ukraine", "beginner", "254", "Andriy", 0);
            visitorRepository.Add(visitor);
            List<Visitor> expected = new List<Visitor>();
            List<Visitor> actual = new List<Visitor>();
            expected.Add(visitor);
            actual = visitorRepository.GetAll();
            Assert.AreEqual(expected[0], actual[0]);

        }

        [TestMethod]
        public void TestVisitorShowDiscount()
        {
            Repository<Visitor> visitorRepository;
            //var factory = FactoryCreator.GetFactory();
            visitorRepository = new VisitorRepository();
            DateTime now = DateTime.Now;
            string currentdate = now.Day.ToString() + now.Month.ToString();
            Visitor visitor = new Visitor("Maksym", "Ukraine", "beginner", currentdate, "Andriy", 0);
            visitorRepository.Add(visitor);
            double changedprice = 0;
            changedprice += Convert.ToDouble(visitor.Membership_price) * ((100 - Visitor.DISCOUNT) / 100);
            string expected = "Happy Birthday! You received " + Visitor.DISCOUNT + "% discount!!! Now your gym membership price is " + changedprice;
            string actual = visitorRepository.ShowDiscount(0);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestShowTheMostPopularTrainer()
        {
            Repository<Visitor> visitorRepository;
            Repository<Trainer> trainerRepository;
            //var factory = FactoryCreator.GetFactory();
            visitorRepository = new VisitorRepository();
            trainerRepository = new TrainerRepository();
            Visitor visitor1 = new Visitor("Maksym", "Ukraine", "beginner", "254");
            visitorRepository.Add(visitor1);
            Visitor visitor2 = new Visitor("Oksana", "Ukraine", "beginner", "254");
            visitorRepository.Add(visitor2);
            Visitor visitor3 = new Visitor("Olga", "Ukraine", "beginner", "254");
            visitorRepository.Add(visitor3);
            Visitor visitor4 = new Visitor("Maksym", "Ukraine", "beginner", "254");
            visitorRepository.Add(visitor4);
            Visitor visitor5 = new Visitor("Oleg", "Ukraine", "beginner", "254");
            visitorRepository.Add(visitor5);
            Trainer trainer1 = new Trainer("Andriy", 10, 0);
            trainerRepository.Add(trainer1);
            Trainer trainer2 = new Trainer("Maksym", 25, 1);
            trainerRepository.Add(trainer2);
            visitor1 += trainer1;
            visitor2 += trainer1;
            visitor3 += trainer2;
            visitor4 += trainer1;
            visitor5 += trainer2;
            Helper helper = new Helper();
            helper.visitorRepository.data = visitorRepository.data;
            helper.trainerRepository.data = trainerRepository.data;
            string expected = trainer1.Name;
            string actual = helper.ShowTheMostPopularTrainer();
            Assert.AreEqual(expected, actual);

        }

    }
}
