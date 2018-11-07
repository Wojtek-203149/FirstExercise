using System;
using FirstExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFirstExercise
{
    [TestClass]
    public class UsersTest
    {
        Users user = new Users(1, "Wojciech", "Mincikiewicz", 1996);

        [TestMethod]
        public void TestGetId()
        {
            int id = user.getId();
            Assert.AreEqual(id, 1);
        }

        [TestMethod]
        public void TestGetName()
        {
            String name = user.getName();
            Assert.AreEqual(name, "Wojciech");
        }

        [TestMethod]
        public void TestGetSurname()
        {
            String surname = user.getSurname();
            Assert.AreEqual(surname, "Mincikiewicz");
        }

        [TestMethod]
        public void TestGetDate()
        {
            int date = user.getDate();
            Assert.AreEqual(date, 1996);
        }

    }
}
