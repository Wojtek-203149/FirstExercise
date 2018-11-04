using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Catalog
    {
        private string authorsName;
        private string authorsSurname;
        private int publicationDate;
        private string title;
        private int key;

        public Catalog(string authorsName, string authorsSurname, int publicationDate, string title, int key)
        {
            this.authorsName = authorsName;
            this.authorsSurname = authorsSurname;
            this.publicationDate = publicationDate;
            this.title = title;
            this.key = key;
        }

        public string getAuthorsName()
        {
            return this.authorsName;
        }

        public void setAuthorsName(string authorsName)
        {
            this.authorsName = authorsName;
        }

        public string getAuthorsSurname()
        {
            return this.authorsSurname;
        }

        public void setAuthorsSurname(string authorsSurname)
        {
            this.authorsSurname = authorsSurname;
        }

        public int getPublicationDate()
        {
            return this.publicationDate;
        }

        public void setPublicationDate(int publicationDate)
        {
            this.publicationDate = publicationDate;
        }

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public int getKey()
        {
            return this.key;
        }

        public void setKey(int key)
        {
            this.key = key;
        }

        public override string ToString()
        {
            return "Author: " + this.authorsName + " " + this.authorsSurname +  " Title: " + this.title + " Publication date: " + this.publicationDate + " Key: " + this.key;
        }
    }

}
