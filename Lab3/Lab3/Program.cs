using System;

namespace Lab3
{
   /* Lab 3 Task 2
    * 2) compare and contrast single selection if and while repetiton statement:
    *    Both statements test for a condition to be true BEFORE executing a 
    *       statement or block of statements.
    *    Both do not need brackets if only 1 statement is performed (although 
    *       the use of brackets is still advised for avoiding logic errors.
    *    They differ because the single selection if statement does not loop
    *       back and repeat whereas the while statement continues to loop until
    *       the condition is false.
    */

   class Program
   {
      static void Main(string[] args)
      {
         /* I added blocks separating each task so as to force
          * the variables in each task to be local to only that
          * task. (thus requiring declaration in each section)
          */

         {
            // Lab3 Task 3 single selection if statement
            Console.WriteLine("Task 3: Use IF statement to output if speed > speedLimit\n");
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
               Console.WriteLine("SLOW NOW");
            }

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs
         }

         {
            // Lab3 Task 4 double selection if-else statement with true value
            Console.WriteLine("Task 4: Use IF-ELSE statements to show condition of bool variable isTrue\n");
            bool isTrue = true;

            if (isTrue)
            {
               Console.WriteLine("It is True!");
            }
            else
            {
               Console.WriteLine("It is False!");
            }

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs
         }

         {
            // Lab3 Task 4 identical code except with false value
            Console.WriteLine("Task 4: changed value of bool variable isTrue to false\n");
            bool isTrue = false;

            if (isTrue)
            {
               Console.WriteLine("It is True!");
            }
            else
            {
               Console.WriteLine("It is False!");
            }

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs
         }

         {
            // Lab3 Task 5 F to C temperature conversion
            Console.WriteLine("Task 5: Convert user supplied Fahrenheit temperature to Celsius.");
            Console.WriteLine("        Use IF statements to show hot or cold warning\n");
            Console.Write("Enter the temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"\n\n {fahrenheit} degrees Fahrenheit = {celsius:F} degrees Celsius."); // rounding celsius calculation to 2 decimal places
            if (fahrenheit < 40)
            {
               Console.WriteLine("It is cold");
            }
            else if (fahrenheit > 90)
            {
               Console.WriteLine("It is hot");
            }

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs
         }

         {
            // Lab3 Task 6 while loop output 1 to 10 increment by 1
            Console.WriteLine("Task 6: Display numbers 1 to 10 increment by 1\n");
            int counter = 1;

            while (counter <= 10)
            {
               Console.Write($"{counter}, ");
               counter++;
            }
            Console.WriteLine("\b\b ");

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs

         }

         {
            // Lab3 Task 7 while loop output 60 to 20 decrement by 5
            Console.WriteLine("Task 7: Display numbers 60 to 20 decrement by 5\n");
            int counter = 60;

            while (counter >= 20)
            {
               Console.Write($"{counter}, "); 
               counter -=5;
            }
            Console.WriteLine("\b\b ");

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs
         }

         {
            // Lab3 Task 8 while loop output 10 to 20 increment by 2
            Console.WriteLine("Task 8: Display numbers 10 to 20 increment by 2\n");
            int counter = 10;
            while (counter <= 20)
            {
               Console.Write($"{counter}, ");
               counter +=2;
            }
            Console.WriteLine("\b\b ");

            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine(); // Added this to separate programs
         }
      }
   }
}



