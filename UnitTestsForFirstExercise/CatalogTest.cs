using System;
using FirstExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFirstExercise
{
    [TestClass]
    public class CatalogTest
    {
        Catalog catalog = new Catalog("Andrzej", "Sapkowski", 2000, "The Witcher", 1);

        [TestMethod]
        public void TestGetKey()
        {
            int key = catalog.getKey();
            Assert.AreEqual(key, 1);
        }

        [TestMethod]
        public void TestGetAuthorsName()
        {
            String authorsName = catalog.getAuthorsName();
            Assert.AreEqual(authorsName, "Andrzej");
        }

        [TestMethod]
        public void TestGetAuthorsSurname()
        {
            String authorsSurname = catalog.getAuthorsSurname();
            Assert.AreEqual(authorsSurname, "Sapkowski");
        }

        [TestMethod]
        public void TestGetTitle()
        {
            String title = catalog.getTitle();
            Assert.AreEqual(title, "The Witcher");
        }

        [TestMethod]
        public void TestGetPublicationDate()
        {
            int publicationDate = catalog.getPublicationDate();
            Assert.AreEqual(publicationDate, 2000);
        }
    }
}
