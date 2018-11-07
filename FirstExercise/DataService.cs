using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class DataService
    {
        private DatabaseActions data;

        public DataService()
        {
            DataFiller filler = new DefaultDataGeneration();
            data = new DatabaseActions(filler);
            data.setData(new DataChamber());
            data.UseFiller();
        }

        public DataService(DatabaseActions data)
        {
            this.data = data;
        }

        public void ListAllUsers()
        {
            if (data.ReadAllUsers().Count != 0)
            {
                foreach (Users item in data.ReadAllUsers())
                {
                    System.Console.WriteLine(item);
                }
            }
            else
            {
                System.Console.WriteLine("Users list is empty");
            }
        }

        public void ListCatalog()
        {
            if (data.ReadAllCatalogs().Count != 0)
            {
                foreach (KeyValuePair<int, Catalog> item in data.ReadAllCatalogs())
                {
                    System.Console.WriteLine(item.Value);
                }
            }
            else
            {
                System.Console.WriteLine("Catalog is empty");
            }
        }

        public void ListAllEvents()
        {
            if (data.ReadAllEvents().Count != 0)
            {
                foreach (Event item in data.ReadAllEvents())
                {
                    System.Console.WriteLine(item);
                }
            }
            else
            {
                System.Console.WriteLine("Events list is empty");
            }
        }

        public void ListAllProcessStates()
        {
            if (data.ReadAllProcessStates().Count != 0)
            {
                foreach (ProcessState item in data.ReadAllProcessStates())
                {
                    System.Console.WriteLine(item);
                }
            }
            else
            {
                System.Console.WriteLine("Process state list is empty");
            }
        }

        public void SearchForUserName(string name)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if(item.getUsers().getName() == name)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if(isEmpty == true)
            {
                System.Console.WriteLine("There is no user with such a name");
            }
        }

        public void SearchForUserSurName(string surname)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getUsers().getSurname() == surname)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no user with such a surname");
            }
        }

        public void SearchForUserDate(int date)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getUsers().getDate() == date)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no user with such a date");
            }
        }

        public void SearchForUserId(int id)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getUsers().getId() == id)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no user with such a id");
            }
        }

        public void SearchForAuthorName(string name)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getCatalog().getAuthorsName() == name)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no author with such a name");
            }
        }

        public void SearchForAuthorSurName(string surname)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getCatalog().getAuthorsSurname() == surname)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no author with such a surname");
            }
        }

        public void SearchForTitle(string title)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getCatalog().getTitle() == title)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no book with such a title");
            }
        }

        public void SearchForPublicationDate(int publicationDate)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getCatalog().getPublicationDate() == publicationDate)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no book with such a publication date");
            }
        }

        public void SearchForPublisher(string publisher)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getPublisher() == publisher)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no book with such a publisher");
            }
        }

        public void SearchForBookState(string bookState)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getBookState() == bookState)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no book with such a book state");
            }
        }

        public void SearchForReleaseDate(int releaseDate)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getProcessState().getReleaseDate() == releaseDate)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no book with such a release date");
            }
        }

        public void SearchBetweenDates(DateTime from, DateTime to)
        {
            bool isEmpty = true;
            foreach (Event item in data.ReadAllEvents())
            {
                if (item.getCheckOutDate() > from && item.getCheckOutDate() < to)
                {
                    System.Console.WriteLine(item);
                    isEmpty = false;
                }
            }
            if (isEmpty == true)
            {
                System.Console.WriteLine("There is no book available between those dates");
            }
        }

        public void AddUser(Users user)
        {
            data.AddUser(user);
        }

        public void AddCatalog(Catalog catalog)
        {
            data.AddCatalog(catalog);
        }

        public void AddEvent(Event evn)
        {
            data.AddEvent(evn);
        }

        public void AddProcessState(ProcessState process)
        {
            data.AddProcessState(process);
        }

        public void DeleteUser(int position)
        {
            data.DeleteUser(position);
        }

        public void DeleteCatalog(int position)
        {
            data.DeleteCatalog(position);
        }

        public void DeleteEvent(int position)
        {
            data.DeleteEvent(position);
        }

        public void DeleteProcessState(int position)
        {
            data.DeleteProcessState(position);
        }
    }
}
