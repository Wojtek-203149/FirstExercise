using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class DataChamber
    {
        private List<Users> usersList;
        private Dictionary<int, Catalog> catalogDictionary;
        private List<Event> eventsList;
        private List<ProcessState> processStateList;

        public DataChamber(List<Users> usersList, Dictionary<int, Catalog> catalogDictionary, List<Event> eventsList, List<ProcessState> processStateList)
        {
            this.usersList = usersList;
            this.catalogDictionary = catalogDictionary;
            this.eventsList = eventsList;
            this.processStateList = processStateList;
        }

        public DataChamber()
        {
            this.usersList = new List<Users>();
            this.catalogDictionary = new Dictionary<int, Catalog>();
            this.eventsList = new List<Event>();
            this.processStateList = new List<ProcessState>();
        }

        public List<Users> getUsersList()
        {
            return this.usersList;
        }

        public void setUsersList(List<Users> usersList)
        {
            this.usersList = usersList;
        }

        public Dictionary<int,Catalog> getCatalogDictionary()
        {
            return this.catalogDictionary;
        }

        public void setCatalogDictionary(Dictionary<int, Catalog> catalogDictionary)
        {
            this.catalogDictionary = catalogDictionary;
        }

        public List<Event> getEventsList()
        {
            return this.eventsList;
        }

        public void setEventsList(List<Event> eventsList)
        {
            this.eventsList = eventsList;
        }

        public List<ProcessState> getProcessStateList()
        {
            return this.processStateList;
        }

        public void setProcessStateList(List<ProcessState> processStateList)
        {
            this.processStateList = processStateList;
        }
    }
}
