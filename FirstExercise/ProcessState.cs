using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class ProcessState
    {
        private Catalog catalog;
        private string publisher;
        private int releaseDate;
        private string bookState;

        public ProcessState(Catalog catalog, string publisher, int releaseDate, string bookState)
        {
            this.catalog = catalog;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.bookState = bookState;
        }

        public Catalog getCatalog()
        {
            return this.catalog;
        }

        public void setCatalog(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public string getPublisher()
        {
            return this.publisher;
        }

        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public int getReleaseDate()
        {
            return this.releaseDate;
        }

        public void setReleaseDate(int releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public string getBookSate()
        {
            return this.bookState;
        }

        public void setBookSate(string bookState)
        {
            this.bookState = bookState;
        }

        public override string ToString()
        {
            return this.catalog.ToString() + "   Publisher: " + this.publisher + " Release date: " + this.releaseDate + " Book state: " + this.bookState;
        }
    }
}
