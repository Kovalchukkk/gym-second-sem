using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gym;

namespace GymTests
{
    [TestClass]
    public class GymTests
    {
        [TestMethod]
        public void TestAddTrainerToVisitor_ReturnsVisitorWithTrainer()
        {
            Visitor visitor = new Visitor("Maksym", "Ukraine", "beginner", "254");
            Trainer trainer = new Trainer("Andriy", 10);
            Visitor actual = new Visitor();
            Visitor expected = new Visitor("Maksym", "Ukraine", "beginner", "254", "Andriy", 0);
            actual = visitor + trainer;
            bool expectedRes = true;
            bool actualRes = actual.Personal_trainer == expected.Personal_trainer;
            Assert.AreEqual(expectedRes, actualRes);
        }

        [TestMethod]
        public void TestVisitorToString()
        {
            Visitor visitor = new Visitor("Maksym", "Ukraine", "beginner", "254", "Andriy", 10);
            string expected = $"Visitor: {visitor.Name}\t\tCountry: {visitor.Country}\t\tMembership card: {visitor.Membership_card}\t\tTrainer: {visitor.Personal_trainer} Trainer id: {visitor.Trainer_id}";
            string actual = visitor.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrainerToString()
        {
            Trainer trainer = new Trainer("Andriy", 10); 
            string expected = $"Trainer: {trainer.Name}\t\tExperience: {trainer.Experience}\t\tId: {trainer.Id}";
            string actual = trainer.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
