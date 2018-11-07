using System;
using System.Collections.Generic;
using FirstExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFirstExercise
{
    [TestClass]
    public class DatabaseActionsTest
    {

        [TestMethod]
        public void GetDataTest()
        {
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data);

            Assert.AreEqual(data, test.getData());
        }

        [TestMethod]
        public void SetDataTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(filler);
            test.setData(data);

            Assert.AreEqual(data, test.getData());
        }

        [TestMethod]
        public void GetFillerTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(filler);

            Assert.AreEqual(filler, test.getFiller());
        }

        [TestMethod]
        public void SetFillerTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data);
            test.setFiller(filler);

            Assert.AreEqual(filler, test.getFiller());
        }

        [TestMethod]
        public void AddUserTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users user = new Users(5, "Wojciech", "Mincikiewicz", 1996);
            test.AddUser(user);

            Assert.AreEqual(test.ReadUser(5), user);
        }

        [TestMethod]
        public void AddCatalogTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog catalog = new Catalog("Andrzej", "Sapkowski", 2000, "The Witcher", 8);
            test.AddCatalog(catalog);

            Assert.AreEqual(test.ReadCatalog(8), catalog);
        }

        [TestMethod]
        public void AddProcessStateTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog catalog = new Catalog("Andrzej", "Sapkowski", 2000, "The Witcher", 8);
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            test.AddProcessState(processState);

            Assert.AreEqual(test.ReadProcessState(5), processState);
        }

        [TestMethod]
        public void AddEventTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users user = new Users(1, "Wojciech", "Mincikiewicz", 1996);
            Catalog catalog = new Catalog("Andrzej", "Sapkowski", 2000, "The Witcher", 8);
            ProcessState processState = new ProcessState(catalog, "Znak", 1990, "Good");
            DateTime checkOutDate = new DateTime(2010, 10, 12);
            DateTime checkInDate = new DateTime(1993, 4, 6);
            Event evn = new Event(processState, user, checkOutDate, checkInDate);
            test.AddEvent(evn);

            Assert.AreEqual(test.ReadEvent(5), evn);
        }

        [TestMethod]
        public void ReadUserTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users readUser = test.ReadUser(3);
            //Users user4 = new Users(3, "Andrzej", "Paluch", 1996);

            Assert.AreEqual(readUser.getName(), "Andrzej");
            Assert.AreEqual(readUser.getSurname(), "Paluch");
            Assert.AreEqual(readUser.getId(), 3);
            Assert.AreEqual(readUser.getDate(), 1996);
            //Assert.AreEqual(readUser, user4);
        }

        [TestMethod]
        public void ReadCatalogTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog readCatalog = test.ReadCatalog(3);

            Assert.AreEqual(readCatalog.getAuthorsName(), "Scott");
            Assert.AreEqual(readCatalog.getAuthorsSurname(), "Fitzgerald");
            Assert.AreEqual(readCatalog.getTitle(), "The Great Gatsby");
            Assert.AreEqual(readCatalog.getKey(), 3);
            Assert.AreEqual(readCatalog.getPublicationDate(), 1925);
        }

        [TestMethod]
        public void ReadProcessStateTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            ProcessState readProcessState = test.ReadProcessState(3);

            Assert.AreEqual(readProcessState.getCatalog().getAuthorsName(), "Harper");
            Assert.AreEqual(readProcessState.getCatalog().getAuthorsSurname(), "Lee");
            Assert.AreEqual(readProcessState.getCatalog().getTitle(), "To Kill a Mockingbird");
            Assert.AreEqual(readProcessState.getCatalog().getPublicationDate(), 1960);
            Assert.AreEqual(readProcessState.getCatalog().getKey(), 1);
            Assert.AreEqual(readProcessState.getPublisher(), "Znak");
            Assert.AreEqual(readProcessState.getBookState(), "Bad");
            Assert.AreEqual(readProcessState.getReleaseDate(), 2001);
        }

        [TestMethod]
        public void ReadEventTest()
        {
            DataChamber data = new DataChamber();
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DatabaseActions test = new DatabaseActions(data, filler);
            DateTime checkOutDate = new DateTime(2018, 4, 6);
            DateTime checkInDate = new DateTime(2018, 12, 12);
            Event readEvent = test.ReadEvent(3);

            Assert.AreEqual(readEvent.getProcessState().getCatalog().getAuthorsName(), "George");
            Assert.AreEqual(readEvent.getProcessState().getCatalog().getAuthorsSurname(), "Orwell");
            Assert.AreEqual(readEvent.getProcessState().getCatalog().getTitle(), "1984");
            Assert.AreEqual(readEvent.getProcessState().getCatalog().getPublicationDate(), 1949);
            Assert.AreEqual(readEvent.getProcessState().getCatalog().getKey(), 2);
            Assert.AreEqual(readEvent.getProcessState().getPublisher(), "Amber");
            Assert.AreEqual(readEvent.getProcessState().getBookState(), "Average");
            Assert.AreEqual(readEvent.getProcessState().getReleaseDate(), 1986);
            Assert.AreEqual(readEvent.getUsers().getName(), "Kasia");
            Assert.AreEqual(readEvent.getUsers().getSurname(), "Kowalska");
            Assert.AreEqual(readEvent.getUsers().getDate(), 1993);
            Assert.AreEqual(readEvent.getUsers().getId(), 1);
            Assert.AreEqual(readEvent.getCheckOutDate(), checkOutDate);
            Assert.AreEqual(readEvent.getCheckInDate(), checkInDate);
        }

        [TestMethod]
        public void ReadAllUsersTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            List<Users> usersList = new List<Users>();
            Dictionary<int, Catalog> catalogDictionary = new Dictionary<int, Catalog>();
            List<Event> eventsList = new List<Event>();
            List<ProcessState> processStateList = new List<ProcessState>();
            DataChamber data = new DataChamber(usersList,catalogDictionary, eventsList, processStateList);

            DatabaseActions test = new DatabaseActions(data, filler);

            Assert.AreEqual(usersList, test.ReadAllUsers());
        }

        [TestMethod]
        public void ReadAllCatalogsTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            List<Users> usersList = new List<Users>();
            Dictionary<int, Catalog> catalogDictionary = new Dictionary<int, Catalog>();
            List<Event> eventsList = new List<Event>();
            List<ProcessState> processStateList = new List<ProcessState>();
            DataChamber data = new DataChamber(usersList, catalogDictionary, eventsList, processStateList);

            DatabaseActions test = new DatabaseActions(data, filler);

            Assert.AreEqual(catalogDictionary, test.ReadAllCatalogs());
        }

        [TestMethod]
        public void ReadAllProcessStatesTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            List<Users> usersList = new List<Users>();
            Dictionary<int, Catalog> catalogDictionary = new Dictionary<int, Catalog>();
            List<Event> eventsList = new List<Event>();
            List<ProcessState> processStateList = new List<ProcessState>();
            DataChamber data = new DataChamber(usersList, catalogDictionary, eventsList, processStateList);

            DatabaseActions test = new DatabaseActions(data, filler);

            Assert.AreEqual(processStateList, test.ReadAllProcessStates());
        }

        [TestMethod]
        public void ReadAllEventsTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            List<Users> usersList = new List<Users>();
            Dictionary<int, Catalog> catalogDictionary = new Dictionary<int, Catalog>();
            List<Event> eventsList = new List<Event>();
            List<ProcessState> processStateList = new List<ProcessState>();
            DataChamber data = new DataChamber(usersList, catalogDictionary, eventsList, processStateList);

            DatabaseActions test = new DatabaseActions(data, filler);

            Assert.AreEqual(eventsList, test.ReadAllEvents());
        }

        [TestMethod]
        public void UpdateUsersTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users newUser = new Users(1, "Test", "Testowy", 1908);
            test.UpdateUser(1, newUser);

            Assert.AreEqual(newUser, test.ReadUser(1));
        }

        [TestMethod]
        public void UpdateCatalogTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog newCatalog = new Catalog("Lokok", "Test", 1908, "Testowy",9);
            test.UpdateCatalog(3, newCatalog);

            Assert.AreEqual(newCatalog, test.ReadCatalog(3));
        }

        [TestMethod]
        public void UpdateProcessStateTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog newCatalog = new Catalog("Lokok", "Test", 1908, "Testowy", 9);
            ProcessState newProcessState = new ProcessState(newCatalog, "Testowy", 1789, "Bad");
            test.UpdateProcessState(4, newProcessState);

            Assert.AreEqual(newProcessState, test.ReadProcessState(4));
        }

        [TestMethod]
        public void UpdateEventTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users newUser = new Users(1, "Test", "Testowy", 1908);
            Catalog newCatalog = new Catalog("Lokok", "Test", 1908, "Testowy", 9);
            ProcessState newProcessState = new ProcessState(newCatalog, "Testowy", 1789, "Bad");
            DateTime checkOutDate = new DateTime(2000, 10, 12);
            DateTime checkInDate = new DateTime(1990, 4, 6);
            Event newEvent = new Event(newProcessState, newUser, checkOutDate, checkInDate);
            test.UpdateEvent(2, newEvent);

            Assert.AreEqual(newEvent, test.ReadEvent(2));
        }

        [TestMethod]
        public void DeleteUsersTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users newUser = new Users(1, "Test", "Testowy", 1908);
            test.AddUser(newUser);
            Assert.AreEqual(test.ReadUser(5), newUser);

            test.DeleteUser(5);
            Assert.IsFalse(test.ReadAllUsers().Contains(newUser));
        }

        [TestMethod]
        public void DeleteCatalogTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog newCatalog = new Catalog("Lokok", "Test", 1908, "Testowy", 5);
            test.AddCatalog(newCatalog);
            Assert.AreEqual(test.ReadCatalog(5), newCatalog);

            test.DeleteCatalog(5);
            Assert.IsFalse(test.ReadAllCatalogs().ContainsValue(newCatalog));
        }

        [TestMethod]
        public void DeleteProcessStateTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Catalog newCatalog = new Catalog("Lokok", "Test", 1908, "Testowy", 9);
            ProcessState newProcessState = new ProcessState(newCatalog, "Testowy", 1789, "Bad");
            test.AddProcessState(newProcessState);
            Assert.AreEqual(test.ReadProcessState(5), newProcessState);

            test.DeleteProcessState(5);
            Assert.IsFalse(test.ReadAllProcessStates().Contains(newProcessState));
        }

        [TestMethod]
        public void DeleteEventTest()
        {
            DefaultDataGeneration filler = new DefaultDataGeneration();
            DataChamber data = new DataChamber();
            DatabaseActions test = new DatabaseActions(data, filler);
            Users newUser = new Users(1, "Test", "Testowy", 1908);
            Catalog newCatalog = new Catalog("Lokok", "Test", 1908, "Testowy", 9);
            ProcessState newProcessState = new ProcessState(newCatalog, "Testowy", 1789, "Bad");
            DateTime checkOutDate = new DateTime(2000, 10, 12);
            DateTime checkInDate = new DateTime(1990, 4, 6);
            Event newEvent = new Event(newProcessState, newUser, checkOutDate, checkInDate);
            test.AddEvent(newEvent);
            Assert.AreEqual(test.ReadEvent(5), newEvent);

            test.DeleteEvent(5);
            Assert.IsFalse(test.ReadAllEvents().Contains(newEvent));
        }
    }
}
