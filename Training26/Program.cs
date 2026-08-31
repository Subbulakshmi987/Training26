// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program to validate a word and calculate its score based on the given rules.
// ------------------------------------------------------------------------------------------------

namespace Training26 {
   class Program {
      static void Main () {
         string allowedletters = "UXALTINE";
         Console.Write ("Enter a word");
         string word = Console.ReadLine ().ToUpper ();
         if (word.Length < 4) {
            Console.WriteLine ("Invalid word. The word must contain atleast 4 letters.");
            return;
         }
         if (!word.Contains ('U')) {
            Console.WriteLine ("Invalid word.The word must contain the letter 'U'.");
            return;
         }
         foreach (char ch in allowedletters) {
            if (!allowedletters.Contains (ch)) {
               Console.WriteLine ("Invalid word.The word contains letters outside the allowed set.");
               return;
            }
         }
         int score;
         if (word.Length == 4)
            score = 1;
         else
            score = word.Length;
         bool pangram = true;
         foreach (char ch in allowedletters) {
            if (!word.Contains (ch)) {
               pangram = false;
               break;
            }
         }
         if (pangram) {
            score += 7;
            Console.WriteLine ("It is a Pangram");
         } else {
            Console.WriteLine ("Valid word");
         }
         Console.WriteLine ("Score: " + score);
      }
   }
}
      

         

      

       

         