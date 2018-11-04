using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Users
    {
        private int id;
        private string name;
        private string surname;
        private int date;

        public Users(int id, string name, string surname, int date)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.date = date;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public int getDate()
        {
            return this.date;
        }

        public void setDate(int date)
        {
            this.date = date;
        }

        public override string ToString()
        {
            return this.id + " " + this.name + " " + this.surname + " " + this.date;
        }

    }
}
