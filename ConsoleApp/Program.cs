using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstExercise;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataService data = new DataService();

            //DefaultDataGeneration dataGeneration = new DefaultDataGeneration();
            RandomDataGeneration ranDataGeneration = new RandomDataGeneration();
            DataChamber chamber = new DataChamber();
            //DatabaseActions databaseActions = new DatabaseActions(chamber, dataGeneration);
            DatabaseActions databaseActions = new DatabaseActions(chamber, ranDataGeneration);
            DataService data = new DataService(databaseActions);


            data.ListAllUsers();
            System.Console.WriteLine("\n");
            data.ListCatalog();
            System.Console.WriteLine("\n");
            data.ListAllProcessStates();
            System.Console.WriteLine("\n");
            data.ListAllEvents();
            System.Console.WriteLine("\n");
            data.SearchForUserName("Wojtek");
            System.Console.WriteLine("\n");
            data.SearchForAuthorName("Andrzej");
            System.Console.WriteLine("\n");
            data.SearchBetweenDates(new DateTime(10, 10, 10), (new DateTime(2017, 10, 10)));
            System.Console.WriteLine("\n");


            System.Console.ReadKey();
        }
    }
}
