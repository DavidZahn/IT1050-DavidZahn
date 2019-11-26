using System;

namespace Lab6
{
   /* Task 2: Fill in the blanks:
    * "A one-dimensional array p contains four elements. The array
    * access exprressions to access each of the elements in p are
    * __p[0]__, __p[1]__, __p[2]__ and __p[3]__."
    */
    
   class Program
   {
      static void Main(string[] args)
      {
         {
            // Task 3: 12 element array for the months
            string[] months = {"January","February","March",
                               "April","May","June","July",
                               "August","September","October",
                               "November","December"};
            for (int i = 0; i < months.Length; i++)
            {
               // I used i+1 so that January isn't the 0th month.
               Console.WriteLine("{0,2}. {1}", i+1, months[i]);
            }
         }
         Console.WriteLine("Press <ENTER> to continue");
         Console.ReadLine();
         {
            // Task 4: Create 4 element array of seasons
            // Note: I was OH SO tempted to make the following array:
            // string[] seasons = { "Crappy", "Wet", "Construction", "Pretty" };

            string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
            foreach (var season in seasons)
            {
               Console.WriteLine(season);
            }
         }
         Console.WriteLine("Press <ENTER> to continue");
         Console.ReadLine();
         {
            // Task 5: 1000 random numbers
            Random random = new Random();
            int[] randomNumber = new int[1000];
            
            for (int i = 0; i < randomNumber.Length; i++)
            {
               randomNumber[i] = random.Next(0, 100);
            }
            foreach (var numberRandom in randomNumber)
            {
               Console.Write(numberRandom);
               Console.Write(" ");
            }
         }
         Console.WriteLine("Press <ENTER> to continue");
         Console.ReadLine();
         {
            // Task 6: Fix the code (2 minor modifications)
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
               Console.WriteLine(names[i]); // Change names[0] to names[i]
               i++;  // Added to increment the counter and avoid an infinite loop
            }
         }
         Console.WriteLine("Press <ENTER> to continue");
         Console.ReadLine();
         {
            // Task 7: Modify code from problem 5 (going to assume you meant 6)
            //         to display the number first then the name.
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
               Console.WriteLine("{0,2}. {1}", i, names[i]);
               i++;
            }
         }
         Console.WriteLine("Press <ENTER> to continue");
         Console.ReadLine();
         {
            // Task 8: Modify code from problem 6 (again, going to assume you meant 7?)
            //         to use foreach instead of while.
            //         Keep the exact same output.
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            foreach (var name in names)
            {
               Console.WriteLine("{0,2}. {1}", i, name);
               i++;
            }
         }
         Console.WriteLine("Press <ENTER> to continue");
         Console.ReadLine();

         /* Post Script: I changed the months to 1-12 because the
          * assignment said output "the number" and name of each month.
          * January is the 1st month, not the 0th. I could have made
          * the array have an empty string for the first item to achieve
          * the same effect but the instructions specifically said to make
          * a 12 element array and that would have made it a 13 element array.
          * 
          * I did NOT make the same modification in the listed names
          * because problem 7 just said output "a number" as opposed
          * to the months which usually are specifically numbered.
          * 
          * I hope this is OK.
          */
      }
   }
}
