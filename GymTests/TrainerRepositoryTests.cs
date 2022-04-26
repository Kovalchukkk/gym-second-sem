using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gym;
using System.Collections.Generic;

namespace GymTests
{
    [TestClass]
    public class TrainerRepositoryTests
    {
        
        [TestMethod]
        public void TestDeleteTrainerByNegIndex_ThrowException()
        {
            Repository<Trainer> trainerRepository;
            var factory = FactoryCreator.GetFactory();
            trainerRepository = factory.GetTrainerRepository();
            Assert.ThrowsException<Exception>(() => trainerRepository.Del(-1));
        }

        [TestMethod]
        public void TestAddTrainer()
        {
            Repository<Trainer> trainerRepository;
            var factory = FactoryCreator.GetFactory();
            trainerRepository = factory.GetTrainerRepository();
            Trainer trainer = new Trainer("Andriy", 10, 0);
            trainerRepository.Add(trainer);
            List<Trainer> expected = new List<Trainer>();
            List<Trainer> actual = new List<Trainer>();
            expected.Add(trainer);
            actual = trainerRepository.data;
            Assert.AreEqual(expected[0], actual[0]);

        }

        [TestMethod]
        public void TestMaxTrainer()
        {
            Repository<Trainer> trainerRepository;
            var factory = FactoryCreator.GetFactory();
            trainerRepository = factory.GetTrainerRepository();
            Trainer trainer1 = new Trainer("Andriy", 10, 0);
            trainerRepository.Add(trainer1);
            Trainer trainer2 = new Trainer("Maksym", 25, 1);
            trainerRepository.Add(trainer2);
            Trainer trainer3 = new Trainer("Olexandr", 15, 2);
            trainerRepository.Add(trainer3);
            string expected = "Maksym";
            string actual = trainerRepository.MaxTrainer();
            Assert.AreEqual(expected, actual);

        }
    }
}
