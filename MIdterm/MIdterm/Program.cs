using System;

namespace MIdterm
{
   /* Task 2 3 types of control structures
    *    1) Sequence Structure
    *          Executes commands in sequence as they are written.
    *          built into C#
    *    2) Selection Structure
    *          Executes a block or blocks of commands depending on
    *             a condition or conditions.
    *          IF -- Single-selection statement
    *          IF...Else -- Double-selection statement
    *          SWITCH -- Multiple-selection statement
    *    3) Iteration Structure
    *          Executes a block of code until a condition is not true.
    *          WHILE -- Tests condition before execution
    *          DO...WHILE -- Tests condition after execution
    *          FOR -- Typically used for counter-controlled iteration.
    *          FOREACH -- Used to apply a block of code to each element
    *                     in an array.
    */

   class Program
   {
      static void Main(string[] args)
      {
         /* Because task 3 is an infinite loop,
          * I placed it inside of remarks so the
          * rest of the code tasks could run.
           
          
         {
            // Task 3 Infinite loop
            bool keepLooping = true;
            while (keepLooping)
            {
               ; // used a ; to indicate an empty statement (do nothing)
            }
         }

         */

         {
            // Task 4 while loop outputting powers of 2
            Console.WriteLine("Task 4:\n\n");
            int controlLoop = 2;
            while (controlLoop <= 128)
            {
               Console.WriteLine($"[{controlLoop}]");
               if (controlLoop >= 64)
               {
                  break;
               }
               controlLoop *= 2;
            }
         }
         Console.WriteLine("Press [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs
         {
            // Task 5 FOR loop 49-1 comma separated list (no comma at end)
            Console.WriteLine("Task 5:\n\n");

            for ( int i = 49; i >= 1; i--)
            {
               Console.Write(i);
               if (i > 1)
               {
                  Console.Write(", ");
               }
            }
         }
         Console.WriteLine("\nPress [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs
         {
            // Task 6 WHILE loop output odd numbers 1-21 space separated list
            Console.WriteLine("Task 6:\n\n");

            int i = 1;
            while(i <= 21)
            {
               Console.Write($"{i} ");
               i += 2;
            }
         }
         Console.WriteLine("Press [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs

         /* Task 7 output of code
          *    The output of the code for Task 7 would be a 
          *    single asterisk. It would do this because a DO...WHILE
          *    statement tests its condition AFTER executing its block
          *    of code. The condition (i < n) is false when n = 8 and
          *    i = 11. i was initialized at 10 but incremented by 1 in 
          *    the code block after the first '*' output.
          *    The output of the code using a WHILE statement instead
          *    would nothing as a WHILE statement tests its condition
          *    BEFORE executing its block of code. The condition (i < n)
          *    is still false when n = 8 and i = 10.
          */

         {
            /* Task 8 Explain combining multiple bool values
             *    You would use logic statements to combine condition
             *    statements such as in the following code:
             */
            Console.WriteLine("Task 8:\n\n");

            bool icyRain = false;
            bool tornadoWarning = false;

            if(!icyRain && !tornadoWarning)
            {
               Console.WriteLine("Let's go outside!");
            }

         }
         Console.WriteLine("Press [Enter] to continue.");
         Console.ReadLine(); // Added this to separate programs
         {
            // Extra Credit! Create the desired output using nested loops
            Console.WriteLine("EXTRA CREDIT:\n\n");

            // Create FOR loop for maximum number to count to.
            for (int max = 5;max >= 1; max--)
            {
               Console.Write("          "); // Space away from edge of console window

               // Create variable amount of spacing for triangle shape output
               for(int k = 5 - max; k >= 1; k--)
               {
                  Console.Write(" ");
               }
               
               // Initialize counter and increment
               int counter = 1;
               int increment = 1;
               
               // loop counter up to i and back
               do
               {
                  Console.Write(counter);

                  // check if counter has reached i
                  if (counter >= max)
                  {
                     increment = -increment;
                  }
                  counter += increment;

               } while (counter > 0);
               Console.WriteLine();
            }
         }

      }
   }
}
