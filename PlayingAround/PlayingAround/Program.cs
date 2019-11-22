﻿// Fig. 7.8: Craps.cs
// Craps class simulates the dice game craps.
using System;
namespace PlayingAround
{
   class Craps
   {
      // create random-number generator for use in method RollDice
      private static readonly Random randomNumbers = new Random();

      // enumeration with constants that represent the game status
      private enum Status { Continue, Won, Lost }

      // enumeration with constants that represent common rolls of the dice
      private enum DiceNames
      {
         SnakeEyes = 2,
         Trey = 3,
         Seven = 7,
         YoLeven = 11,
         BoxCars = 12
      }

      // plays one game of craps
      static void Main()
      {
         
         int bank = 1000;
         int bet = PlaceYourBet(bank);
         
         while (bet>0 && bank>0)
         {
            Console.Clear();
            Console.WriteLine("Bank:{0}  Bet:{1}", bank, bet);
            // gameStatus can contain Continue, Won or Lost
            Status gameStatus = Status.Continue;
            int myPoint = 0; // point if no win or loss on first roll
            Console.WriteLine("\n");
            int sumOfDice = RollDice(); // first roll of the dice


            // determine game status and point based on first roll
            switch ((DiceNames)sumOfDice)
            {
               case DiceNames.Seven: // win with 7 on first roll   
               case DiceNames.YoLeven: // win with 11 on first roll
                  gameStatus = Status.Won;
                  break;
               case DiceNames.SnakeEyes: // lose with 2 on first roll
               case DiceNames.Trey: // lose with 3 on first roll     
               case DiceNames.BoxCars: // lose with 12 on first roll 
                  gameStatus = Status.Lost;
                  break;
               default: // did not win or lose, so remember point  
                  gameStatus = Status.Continue; // game is not over
                  myPoint = sumOfDice; // remember the point       
                  Console.WriteLine($"Point is {myPoint}");
                  break;
            }

            // while game is not complete
            while (gameStatus == Status.Continue) // game not Won or Lost
            {
               Console.WriteLine("Press <ENTER> to roll again.");
               Console.ReadLine();
               Console.Clear();
               Console.WriteLine("Bank:{0}  Bet:{1}", bank, bet);
               Console.WriteLine($"Point is {myPoint}\n");


               sumOfDice = RollDice(); // roll dice again

               // determine game status
               if (sumOfDice == myPoint) // win by making point
               {
                  gameStatus = Status.Won;
               }
               else
               {
                  // lose by rolling 7 before point
                  if (sumOfDice == (int)DiceNames.Seven)
                  {
                     gameStatus = Status.Lost;
                  }
               }
            }

            // display won or lost message
            if (gameStatus == Status.Won)
            {
               Console.WriteLine("PLAYER WINS!!!!\n\a");
               bank += bet;
            }
            else
            {
               Console.WriteLine("Player loses.\n\a");
               bank -= bet;
            }

            if (bank <= 0)
            {
               Console.WriteLine("You are BUST.");
            }
            else
            {
               bet = PlaceYourBet(bank);
            }
         }
         Console.Write("\n\nGit outta here");
         if (bank <= 0)
         {
            Console.WriteLine(", ya bum!");
         }
         else
         {
            Console.WriteLine("!");
         }
         if (bank < 0)
         {
            Console.WriteLine("And if ya don't bring me {0},", Math.Abs(bank));
            Console.WriteLine("I'll break ya kneecaps!");
         }

      }

      static int PlaceYourBet(int bank)
      {
         int bet;
         Console.WriteLine($"You have: {bank}");
         Console.WriteLine("Enter your bet (0 to quit):");
         string input = Console.ReadLine();
         if (input == "")
         {
            Console.WriteLine("Enter 0 to quit.");
            bet = PlaceYourBet(bank);
            return bet;
         }
         else
         {
            bet = int.Parse(input);
         }
         if (bet <= bank)
         {
            return bet;
         }
         if (bet <= bank + 100)
         {
            Console.WriteLine("OK, I'll cover ya for it but ya betta win!");
            Console.WriteLine("Press <ENTER> to roll.");
            Console.ReadLine();
            return bet;
         }
         Console.WriteLine("Na, I ain't gonna float you that much!");
         bet = PlaceYourBet(bank);
         return bet;


      }

      // roll dice, calculate sum and display results
      static int RollDice()
      {
         // pick random die values
         int die1 = randomNumbers.Next(1, 7); // first die roll
         int die2 = randomNumbers.Next(1, 7); // second die roll

         int sum = die1 + die2; // sum of die values

         // display results of this roll

         DisplayDice(die1, die2);

         return sum; // return sum of dice
      }


      static void DisplayDice(int die1, int die2)
      {
         int sum = die1 + die2;
         
         string[,] dieFace = new string[,]
         {
            { "   ", "O  ", "O  ", "O O", "O O", "O O" },
            { " O ", "   ", " O ", "   ", " O ", "O O" },
            { "   ", "  O", "  O", "O O", "O O", "O O" }
         };
         Console.WriteLine("Player rolls:");
         Console.WriteLine("╔═════╗  ╔═════╗");
         for (int i=0;i<=2;i++)
         {
            Console.WriteLine("║ {0} ║  ║ {1} ║", dieFace[i,die1-1], dieFace[i,die2-1]);
         }
         Console.WriteLine("╚═════╝  ╚═════╝   =  {0}", (DiceNames) sum);
      }

   }

}