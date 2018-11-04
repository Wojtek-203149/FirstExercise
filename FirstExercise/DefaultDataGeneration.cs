using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class DefaultDataGeneration : DataFiller
    {
        public void Fill(DataChamber data)
        {
            Users user1 = new Users(1, "Wojtek", "Mincikiewicz", 1996);
            Users user2 = new Users(2, "Kasia", "Kowalska", 1993);
            Users user3 = new Users(3, "Michal", "Nowak", 1998);
            Users user4 = new Users(4, "Andrzej", "Paluch", 1996);
            Users user5 = new Users(5, "Mikolaj", "Malolepszy", 1997);

            Catalog book1 = new Catalog("Andrzej", "Sapkowski", 1984, "The Witcher", 0);
            Catalog book2 = new Catalog("Harper", "Lee", 1960, "To Kill a Mockingbird", 1);
            Catalog book3 = new Catalog("George", "Orwell", 1949, "1984", 2);
            Catalog book4 = new Catalog("Scott", "Fitzgerald", 1925, "The Great Gatsby", 3);
            Catalog book5 = new Catalog("John", "Tolkien", 1937, "Hobbit", 4);

            ProcessState ps1 = new ProcessState(book1, "Znak", 1986, "Good");
            ProcessState ps2 = new ProcessState(book1, "Rebis", 1999, "Average");
            ProcessState ps3 = new ProcessState(book4, "PWN", 2006, "Bad");
            ProcessState ps4 = new ProcessState(book2, "Znak", 2001, "Bad");
            ProcessState ps5 = new ProcessState(book3, "Amber", 1986, "Average");

            Event event1 = new Event(ps1, user1, new DateTime(2018, 1, 18), new DateTime(2018, 2, 28));
            Event event2 = new Event(ps1, user3, new DateTime(2016, 4, 18), new DateTime(2017, 3, 7));
            Event event3 = new Event(ps3, user1, new DateTime(2017, 3, 4), new DateTime(2018, 5, 20));
            Event event4 = new Event(ps5, user2, new DateTime(2018, 4, 6), new DateTime(2018, 12, 12));
            Event event5 = new Event(ps4, user5, new DateTime(2014, 11, 14), new DateTime(2015, 9, 9));

            data.getUsersList().Add(user1);
            data.getUsersList().Add(user2);
            data.getUsersList().Add(user3);
            data.getUsersList().Add(user4);
            data.getUsersList().Add(user5);

            data.getCatalogDictionary().Add(book1.getKey(), book1);
            data.getCatalogDictionary().Add(book2.getKey(), book2);
            data.getCatalogDictionary().Add(book3.getKey(), book3);
            data.getCatalogDictionary().Add(book4.getKey(), book4);
            data.getCatalogDictionary().Add(book5.getKey(), book5);

            data.getProcessStateList().Add(ps1);
            data.getProcessStateList().Add(ps2);
            data.getProcessStateList().Add(ps3);
            data.getProcessStateList().Add(ps4);
            data.getProcessStateList().Add(ps5);

            data.getEventsList().Add(event1);
            data.getEventsList().Add(event2);
            data.getEventsList().Add(event3);
            data.getEventsList().Add(event4);
            data.getEventsList().Add(event5);
        }
    }
}
