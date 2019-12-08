using System;

namespace Lab_7
{ 
   public class Book
   {
      public string Title { get; set; }
      public string Author { get; set; }
      public int Year { get; set; }

      // Used default values in constructor to
      // provide for parameterless calls.
      public Book(string title = "Title",string author = "Author",int year = 0)
      {
         Title = title;
         Author = author;
         Year = year;
      }

      // Per instructions, only displaying Title and Author.
      public static void Display(Book book)
      {
         Console.WriteLine("\"{0}\" by {1}", book.Title, book.Author);
      }
   }

   class BookTest
   {
      public static void Main()
      {
         // creating the object myBook using supplied parameters
         Book myBook = new Book("A Darkness At Sethanon","Raymond E. Feist", 1986);
         // call to display method
         Book.Display(myBook);

         // Added the following line to show I can access the
         // other properties of the object myBook
         Console.WriteLine("Published in {0}", myBook.Year);

         Console.WriteLine();

         // creating the object yourBook using parameterless call
         // thus the constructor inserts default values.
         Book yourBook = new Book();
         Book.Display(yourBook);

         // Added the following line to show I can access the
         // other properties of yourBook and that they differ
         // from myBook.
         Console.WriteLine("Published in {0}", yourBook.Year);

      }
   }
   /*  Answers to questions 3-8 (in essay form). 

      (3-4) A constructor is a method that is called when an object is created. It
      initializes the properties in memory and creates the object. A constructor
      is always called when the object is created. Even if a constructor is not
      provided, a default constructor is called that has no parameters or body.
      This default constructor is provided by the compiler when there are no other
      constructors provided. A class can have more than one constructor. When this
      is the case, the constructor is "overloaded". Each version of the overloaded
      constructor must have a different signature which refers to it's parameter list
      variables and types.

      (5) Error handling is an important aspect of app design as it can catch errors that
      the compiler wouldn't. An example would be in an app that allows a user to input
      2 numbers and provides the quotient of the 2 numbers. If the user enters a 0 as
      the second number, this would cause the app to crash and stop working. Error
      handling provides a way that the app can handle the error and then continue with
      the app's operation.

      (6) Access modifiers such as public and private allow an app to present only the
      methods and variables to the user that the user needs to see while keeping the
      inner workings of the app away from prying eyes. This is known as encapsulation.
      A real world analogy would be a car. The end user knows how to accelerate, brake,
      and steer the vehicle. These are public properties of a car. Other properties of
      the car, such as spark plug gaps and fuel injector flow rates would be private.
      The normal user has no idea what they do and there is no need for the user to
      understand them in order to operate the car. In software, this keeps the user
      from being able to corrupt data as it is being handled by the app. Thus the inner
      workings of the app are hidden.

      (7) Composition is referred to as a "has-a" relationship. This is where an object of
      a class can have more than one reference to another object of the same class. In
      our Book class, we could make Author an object (with properties such as Name, Age,
      etc.) and then the object Book would have multiple objects of Author in it as
      properties.

      (8) Data abstraction is the process of dealing only with data that is relative to the
      object at hand. You can use abstract classes that will never be used to create an
      object but has properties that other classes would inherit. In this way, trivial
      or non-essential data is not exhibited to the user. A class that calculates payroll
      would not need to know an employees mother's name. This information would then be
      hidden from the payroll class but could possibly be used in a class that lists an
      employees contact information.
   */
}
