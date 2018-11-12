# FirstExercise
First exercise for Programming Technologies Subject

Small Report

Application is a simulation of library. Catalog, Event, ProcessState and Users are generic classes that hold informations about book, event(which is borrowing a book), particular entity of a book and about person who borrows a book respectively. 

DataChamber class holds objects of four generic classes that I mentioned earlier so that it is easier to populate them in the other part of program.

DataFiller is an Interface which helps me in achieving Dependency Injection goal and allows to have loosely-coupled classes.

RandomDataGeneration and DefaultDataGeneration classes are implementing an interface mentioned above, and are filling my database(DataChamber class) with data. One does it randomly, the other one has fixed values to fill.

DataBaseActions is a class that implements most of the buisness functionality of application. This class allows DataFiller object to be injected by a means of constructor or setter using Dependency Injection. This allows user to fill database in a way that he likes, without need to change code in our class and achieves loosly coupled classes. Method UseFiller fills database using data generation method specified by user. Also in this class we have a set of CRUD methods which are responssible for Creating, Reading, Updating and Deleting databse entries.

DataService is our main class where all the magic happens. Default constructor allows user to create instance of DataService class with already populated and filled database but we also give user a possibility to fill it as he wish using our second constructor. This class also provides methods for displaying and filtering database in a different ways.

UnitTests are testing all four generic classes, data generation classes and DatabaseActions class so that everything works as expected.
