using System;

namespace Lab5
{
   
   class Program
   {
      // Task 2 - Using the method getArea identify and describe 
      //          the following elements

      //  Non-Static is implicit so it is not required 
      //                                    
      //  access  return  method         
      // modifier  type    name         Parameters
      //     ↓      ↓       ↓    ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓
      .    public double getArea(double height, double width)
            {                          // The area between the curly braces
               return height * width;  // is called the method body and is 
            }                          // where the actual code work is done.


      /*
       * in the preceding method's code are the following elements:
       * a. Scope -   Access modifiers such as 'public' and 'private' are used to limit 
       *   (Access    which methods can call that specific method. Public can be used by
       *   modifier)  anything and private can only be used by methods in the same class.
       *              Some  other modifiers are 'protected' and 'internal'.
       *            
       * b. Static vs Non-Static - This refers to whether a method must be called as
       *                           part of an object or not. The example method is 
       *                           implicitly Non-static and must therefore be called
       *                           in relation to an object.
       * 
       *c. Return Type - The return type is specified as 'double' and is located
       *                  after the access modifier 'public'. This specifies that
       *                  the method MUST return a double value when the methods 
       *                  call ends. Some values include 'int', 'string' or 'decimal'.
       *                  If no value was desired the term 'void' would
       *                  be used. 
       * 
       * d. Method name - This method's name is 'getArea'. The method name along with
       *                  the number and type of parameters creates a method signature
       *                  that MUST be unique. You can create more than one method with
       *                  the same name but it must have different parameter requirements.
       *                  This is called 'overloading' a method.
       * 
       * e. Parameters - The parameters of a method are values that can be passed to it
       *                 so that it can perform something to them. Parameters are not 
       *                 required to be passed to it. Included in the parameters can also
       *                 be cast modifiers to change the types as well as keywords to
       *                 modify how the value is passed ('ref' or 'out').
       * 
       * 
       * f. Method Body - This is where the actual work of the method is done. In the
       *                  above example, the body is contained in curly brackets. 
       *                  This isn't always required but is a good practice for readability
       * 
       * 
       * 
       * Task 3 - The difference between user-defined and framework methods:
       *          Framework methods are "tried and true". These are methods that are 
       *          written to do one thing generically such as math functions. They are
       *          meant to be used in a variety of applications. User-defined methods 
       *          are more specific to a certain project or app. Things to consider
       *          when creating user-defined methods:
       *          Is it trying to do too much?
       *          Should it be broken into smaller tasks?
       *          Is there already a method in the framework that does the same thing?
       * 
       * 
       * Task 4 - Static vs. Non-Static
       *                 Unless explicitly called Static in the method header, the method
       *                 is considered Non-Static. A method is declared a Static method, by
       *                 placing the keyword 'Static' between the access modifier and
       *                 the return type. When a method is Static, it can be called by using the 
       *                 class name, followed by the member-access operator (.) and then the
       *                 method name. A Non-Static method must be called in relation to an
       *                 object created by a class by using the object name, followed by the 
       *                 member-access operator (.) and then the method name.
       *                 
       *                 Static method call example - Math.Pow(10,2)  ← parameters
       *                                               ↑    ↑    
       *                                           class  method
       *                                           name    name
       *                 
       *                 Non-Static method call example - myAccount.SetName(theName)  ← parameters
       *                                                      ↑        ↑       
       *                                                  object     method
       *                                                   name       name
       *                
      */

      static void Main(string[] args)
      {
         Dog myDog = new Dog();
         myDog.Name = "Fido";

         // To do: uncomment the following lines of code to call the methods
         myDog.Bark();
         myDog.DoTrick("Fetch");
      }
      class Dog
      {
         public string Name { get; set; }

         // Add bark() method
         public void Bark()
         {
            Console.WriteLine("{0} is Barking...", Name);
         }

         // Add doTrick() method
         public void DoTrick(string trickName)
         {
            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", 
               Name, trickName);
         }
      }
   }
}
