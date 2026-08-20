// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch A01-GuessGame.
// ------------------------------------------------------------------------------------------------
namespace Practice_for_Academy_23 {
   class Program {
      static void Main (string[] args) {
         GuessGame ();
      }
      static void GuessGame () {
         int n = new Random ().Next (1, 101);
         Console.WriteLine ("Enter your number");
         while (true) {
            Console.Write ("Enter your guess between 1 and 100");
            int guess = Convert.ToInt32 (Console.ReadLine ());
            if (guess > n) Console.WriteLine ("Your guess is too high");
            else if (guess < n) Console.WriteLine ("Your guess is too low");
            else {
               Console.WriteLine ("You guess correctly");
               break;
            }
         }
      }
   }
}
