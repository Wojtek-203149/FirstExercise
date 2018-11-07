using System;
using FirstExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFirstExercise
{
    [TestClass]
    public class EventTest
    {
        Users user = new Users(1, "Wojciech", "Mincikiewicz", 1996);
        Catalog catalog = new Catalog("Andrzej", "Sapkowski", 2000, "The Witcher", 1);
        DateTime checkOutDate = new DateTime(2010, 10, 12);
        DateTime checkInDate = new DateTime(1993, 4, 6);

        [TestMethod]
        public void TestGetUsers()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            Event evn = new Event(processState, user, checkOutDate, checkInDate);
            Users usr = evn.getUsers();
            Assert.AreEqual(usr, user);
        }

        [TestMethod]
        public void TestGetProcessState()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            Event evn = new Event(processState, user, checkOutDate, checkInDate);
            ProcessState pS = evn.getProcessState();
            Assert.AreEqual(pS, processState);
        }

        [TestMethod]
        public void TestGetCheckOutDate()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            Event evn = new Event(processState, user, checkOutDate, checkInDate);
            DateTime cOut = evn.getCheckOutDate();
            Assert.AreEqual(cOut, checkOutDate);
        }

        [TestMethod]
        public void TestGetCheckInDate()
        {
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            Event evn = new Event(processState, user, checkOutDate, checkInDate);
            DateTime cIn = evn.getCheckInDate();
            Assert.AreEqual(cIn, checkInDate);
        }

    }
}
