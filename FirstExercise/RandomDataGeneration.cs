using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class RandomDataGeneration : DataFiller
    {
        public void Fill(DataChamber data)
        {
            string[] name = { "Wojtek", "Kasia", "Michal", "Andrzej", "Mikolaj", "Harper", "George", "Scott", "John", "Maria", "Sylwia", "Kinga" };
            string[] surname = { "Mincikiewicz", "Kowalska", "Nowak", "Paluch", "Malolepszy", "Sapkowski", "Lee", "Orwell", "Fitzgerald", "Tolkien", "Rowling", "Bak" };
            string[] title = { "The Witcher", "To Kill a Mockingbird", "1984", "The Great Gatsby", "Hobbit", "Revenge", "The Godfather", "Solaris", "The Lord of the Rings", "Life of PI", "Sillmarion", "Hunger Games" };
            string[] publisher = { "Znak", "Rebis", "PWN", "Amber", "Nowa Era", "Moka" };
            string[] bookState = { "Good", "Average", "Bad" };

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                data.getUsersList().Add(new Users(i, name[rnd.Next(12)], surname[rnd.Next(12)], rnd.Next(1900, 2010)));
            }

            for (int i = 0; i < 10; i++)
            {
                data.getCatalogDictionary().Add(i, new Catalog( name[rnd.Next(12)], surname[rnd.Next(12)], rnd.Next(1900, 2010), title[rnd.Next(12)], i));
            }

            for (int i = 0; i < 10; i++)
            {
                data.getProcessStateList().Add(new ProcessState(data.getCatalogDictionary()[rnd.Next(0,10)], publisher[rnd.Next(6)],  rnd.Next(1900, 2018), bookState[rnd.Next(3)]));
            }

            for (int i = 0; i < 10; i++)
            {
                int years = rnd.Next(2000, 2016);
                int months = rnd.Next(1, 12);
                int days = rnd.Next(1, 28);
                DateTime checkOut = new DateTime(years, months, days);
                DateTime checkIn = new DateTime(years+rnd.Next(1, 2), rnd.Next(1, 12), rnd.Next(1, 28));
                data.getEventsList().Add(new Event(data.getProcessStateList()[rnd.Next(0, 10)], data.getUsersList()[rnd.Next(0, 10)], checkOut, checkIn));
            }
        }
    }
}
