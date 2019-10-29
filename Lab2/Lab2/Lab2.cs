using System;

class Lab2
{
   static void Main()
   {
      int number1;
      int number2;
      int product;

      // Two line "Hello World"
      Console.WriteLine("{0}\n{1}", "Hello World!", "From David Zahn");

      // Single line "Hello World" with tab separation.
      Console.WriteLine("{0}\t{1}", "Hello World!", "From David Zahn");

      Console.Write("Enter first integer: "); // prompt user
      // read first integer from user
      number1 = int.Parse(Console.ReadLine());

      Console.Write("Enter second integer: "); // prompt user
      // read second integer from user
      number2 = int.Parse(Console.ReadLine());

      product = number1 * number2;  // multiply integers and store into product

      Console.WriteLine($"The product is {product}"); // display product



   }  // end Main
}  // end Lab2
   /*
     Answers to questions in section 5 of Lab2 

      a.	At what point in the program does our C# Console Application execution?
            line 5   static void Main()

      b.	What is the difference between an integer type variable and a double / floating-point variable?
            int type variable contain whole integers.
            float type variables contain rational numbers.

            int type variable uses 32 bits and can range from –2,147,483,648 to 2,147,483,647, inclusive
            float type vairable uses 32 bits and can range from:
               Approximate negative range: –3.4028234663852886E+38 to –1.40129846432481707E–45
               Approximate positive range: 1.40129846432481707E–45 to 3.4028234663852886E+38
               Other supported values: positive and negative zero, positive and negative infinity,
               not-a-number (NaN)
               
            (from Apendix B page 978)

      c.	We can create blocks of code that we can call by name using a method.  
         Give an example of a method from Chapter 4.
            public void SetName(string accountName)
            {
               name = accountName; // store the account name
            }

            (from 4.3.1 Account Class Declaration)

      d.	Like we have types double and int, we can create our own custom types using Classes. Each 
         class has variables called instance variables or class members.  To read the value of an instance
         variable, we create method called a ____ accessor.  To assign a value ton instance variable, we 
         use a method called a ____ accessor.
            get accessor reads the value of an instance variable
            set accessor assigns a value to an instance variable
      
      e.	What is the difference between a class and an object?  How many instances of a class can we 
         create (please explain your answer)?
            A class is the template used to create objects. It contains the attributes of that object
            as well as methods to manipulate those attributes.
            An object is an instance of a specific class.
            
            The form used in a database could be considered a class while
            a record in that database could be considered an object.
         
            You can create an unlimited number of objects from a class
   */
            