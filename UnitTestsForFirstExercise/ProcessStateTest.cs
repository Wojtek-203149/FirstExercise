using System;
using FirstExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFirstExercise
{
    [TestClass]
    public class ProcessStateTest
    {
        Catalog catalog = new Catalog("Andrzej", "Sapkowski", 2000, "The Witcher", 1);
        
        [TestMethod]
        public void TestGetCatalog()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            Catalog catalog2 = processState.getCatalog();
            Assert.AreEqual(catalog2, catalog);
        }

        [TestMethod]
        public void TestGetPublisher()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            String publisher = processState.getPublisher();
            Assert.AreEqual(publisher, "Znak");
        }

        [TestMethod]
        public void TestGetSurname()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            String bookState = processState.getBookState();
            Assert.AreEqual(bookState, "Good");
        }

        [TestMethod]
        public void TestGetReleaseDate()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            int releaseDate = processState.getReleaseDate();
            Assert.AreEqual(releaseDate, 1990);
        }
    }
}
