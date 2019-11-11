using System;

namespace Lab4
{
   /* Task 2
    *    The 4 basic elements of a counter-controlled repetition are:
    *       a control variable, the control variable's initial value,
    *       the control variable's increment (or decrement), and
    *       the loop continuation condition.
    *       
    * Task 3
    *    The ways that FOR and WHILE statements are similar:
    *       They both will reiterate a code block,
    *       Both will test the condition BEFORE running the code block.
    *    They differ in the fact that the FOR statement's header can contain
    *       all 4 of the basic elements of a counter-controlled iteration
    *       (see task 2). The WHILE statement could be used in place of a
    *       FOR statement but must have the condition statement in its header
    *       and the code body should contain the increment but can NOT contain
    *       the variable or it's initial value (to avoid an infinite loop).
    *    Because of these similarities and differences, a FOR statement is
    *       more suited to counter-controlled iterations and the WHILE
    *       statement is better suited to sentinal-controlled iterations.
    *    
    * Task 4
    *    The WHILE and DO...WHILE statements are very similar with the main
    *       exception being when the condition is tested. A WHILE statement
    *       tests the condition before executing its code block and a 
    *       DO...WHILE statement tests the code block after executing its
    *       code block. Because of this, the code in a DO...WHILE statement
    *       will always execute at least once. This makes the DO...WHILE
    *       statement very well suited for data entry with a sentinal-controlled
    *       iteration because the data entry would be done at least once. You
    *       could use a WHILE statement that would require a data entry outside
    *       of the code block and then another inside.
    */

   class Program
   {
      static void Main(string[] args)
      {
         {
            // Task 5 1-100 loop with odds and evens
            for(int i = 1;i <= 100;i++)
            {
               // I'm not sure if you wanted the app to output the numbers or not.
               // if so, just remove the "//" part of the next line:
               // Console.Write($"i = {i}. ");
               Console.Write("The variable 'i' contains an integer that is ");
               if ((i % 2) == 0)
               {
                  Console.WriteLine("EVEN");
               }
               else
               {
                  Console.WriteLine("ODD");
               }
            }
         }

         Console.WriteLine("Press [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs
         
         {
            // Task 6 output animals based on temperature input by user

            Console.Write("Please enter a temperature: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 10)
            {
               Console.WriteLine("Polar Bear");
            }
            else if (temp < 20)
            {
               Console.WriteLine("Penguin");
            }
            else if (temp < 40)
            {
               Console.WriteLine("Moose");
            }
            else if (temp < 50)
            {
               Console.WriteLine("Reindeer");
            }
            else if (temp < 60)
            {
               Console.WriteLine("Deer");
            }
            else if (temp < 70)
            {
               Console.WriteLine("Turtle");
            }
            else if (temp < 80)
            {
               Console.WriteLine("Lion");
            }
            else if (temp < 90)
            {
               Console.WriteLine("Fish");
            }
            else
            { 
               Console.WriteLine("Bug");
            }
         }
         Console.WriteLine("Press [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs
         {
            // Task 7 Correct the code for a WHILE loop

            int i = 10;
            while (i < 21)
            {
               Console.WriteLine(i);
               ++i;      // Added the incrementor to correct the program  
            }
         }
         Console.WriteLine("Press [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs
         {
            // Task 8 Correct the code for a FOR loop

            for (int i = 0; i < 101; i++)
            {
               Console.WriteLine(i);
               Console.WriteLine("********");
            }
            // Added brackets around code block
         }








      }
   }
}
