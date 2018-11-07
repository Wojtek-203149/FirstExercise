using System;
using FirstExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFirstExercise
{
    [TestClass]
    public class FillTest
    {
        [TestMethod]
        public void RandomFillTest()
        {
            RandomDataGeneration ranDataGeneration = new RandomDataGeneration();
            DataChamber chamber = new DataChamber();
            DatabaseActions databaseActions = new DatabaseActions(chamber, ranDataGeneration);

            Assert.AreEqual(10, databaseActions.ReadAllCatalogs().Count);
            Assert.AreEqual(10, databaseActions.ReadAllUsers().Count);
            Assert.AreEqual(10, databaseActions.ReadAllProcessStates().Count);
            Assert.AreEqual(10, databaseActions.ReadAllEvents().Count);
        }

        [TestMethod]
        public void DefaultFillTest()
        {
            DefaultDataGeneration defaultDataGeneration = new DefaultDataGeneration();
            DataChamber chamber = new DataChamber();
            DatabaseActions databaseActions = new DatabaseActions(chamber, defaultDataGeneration);

            Assert.AreEqual(5, databaseActions.ReadAllCatalogs().Count);
            Assert.AreEqual(5, databaseActions.ReadAllUsers().Count);
            Assert.AreEqual(5, databaseActions.ReadAllProcessStates().Count);
            Assert.AreEqual(5, databaseActions.ReadAllEvents().Count);
        }
    }
}
