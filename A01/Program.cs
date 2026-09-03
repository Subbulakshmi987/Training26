// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch A01-GuessGame.
// ------------------------------------------------------------------------------------------------

namespace Practice_for_Academy_23 {
   class Program {
      static void Main () {
         static void GuessGame () {
            int n = new Random ().Next (1, 101);
            int maxTries = 7;
            Console.WriteLine ("Guess the number: ");
            for (int tries = 1; tries <= maxTries; tries++) {
               Console.Write ("Enter your guess between 1 and 100: ");
               string input = Console.ReadLine ();
               if (!int.TryParse (input, out int guess)) {
                  Console.WriteLine ("Invalid input. Please enter a valid number.");
                  tries--;
                  continue;
               }
               if (guess < 1 || guess > 100) {
                  Console.WriteLine ("Please enter a number between 1 and 100.");
                  tries--;
                  continue;
               }
               if (guess > n) Console.WriteLine ("Your guess is too high.");
               else if (guess < n) Console.WriteLine ("Your guess is too low.");
               else {
                  Console.WriteLine ("You guessed correctly.");
                  return;
               }
            }
            Console.WriteLine ($"Sorry! You have used all {maxTries} tries.");
            Console.WriteLine ($"The correct number was: {n}");
         }
      }
   }
}
