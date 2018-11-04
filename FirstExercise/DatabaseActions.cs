using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class DatabaseActions
    {
        private DataChamber data;
        private DataFiller filler;

        public DatabaseActions(DataChamber data)
        {
            this.data = data;
        }

        public DatabaseActions(DataFiller filler)
        {
            this.filler = filler;
        }

        public DatabaseActions(DataChamber data, DataFiller filler)
        {
            this.data = data;
            this.filler = filler;
            filler.Fill(data);
        }

        public DataChamber getData()
        {
            return data;
        }

        public void setData(DataChamber data)
        {
            this.data = data;
        }

        public DataFiller getFiller()
        {
            return filler;
        }

        public void setFiller(DataFiller filler)
        {
            this.filler = filler;
        }
        
        public void UseFiller()
        {
            filler.Fill(data);
        }

        public void AddUser(Users user)
        {
            data.getUsersList().Add(user);
        }

        public void AddCatalog(Catalog catalog)
        {
            data.getCatalogDictionary().Add(catalog.getKey(), catalog);
        }

        public void AddEvent(Event evn)
        {
            data.getEventsList().Add(evn);
        }

        public void AddProcessState(ProcessState process)
        {
            data.getProcessStateList().Add(process);
        }

        public Users ReadUser(int position)
        {
            return data.getUsersList()[position];
        }

        public Catalog ReadCatalog(int key)
        {
            return data.getCatalogDictionary()[key];
        }

        public Event ReadEvent(int position)
        {
            return data.getEventsList()[position];
        }

        public ProcessState ReadProcessState(int position)
        {
            return data.getProcessStateList()[position];
        }

        public List<Users> ReadAllUsers()
        {
            return data.getUsersList();
        }

        public Dictionary<int, Catalog> ReadAllCatalogs()
        {
            return data.getCatalogDictionary();
        }

        public List<Event> ReadAllEvents()
        {
            return data.getEventsList();
        }

        public List<ProcessState> ReadAllProcessStates()
        {
            return data.getProcessStateList();
        }

        public void UpdateUser(int position, Users user)
        {
            data.getUsersList()[position] = user;
        }

        public void UpdateCatalog(int position, Catalog catalog)
        {
            data.getCatalogDictionary()[position] = catalog;
        }

        public void UpdateEvent(int position, Event evn)
        {
            data.getEventsList()[position] = evn;
        }

        public void UpdateProcessState(int position, ProcessState processState)
        {
            data.getProcessStateList()[position] = processState;
        }

        public void DeleteUser(int position)
        {
            data.getUsersList().RemoveAt(position);
        }

        public void DeleteCatalog(int position)
        {
            data.getCatalogDictionary().Remove(position);
        }

        public void DeleteEvent(int position)
        {
            data.getEventsList().RemoveAt(position);
        }

        public void DeleteProcessState(int position)
        {
            data.getProcessStateList().RemoveAt(position);
        }
    }
}
