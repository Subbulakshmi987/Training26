// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch main.
// ------------------------------------------------------------------------------------------------
namespace Training26;

class Program {
   static void Main (string[] args) {
      int[] arr = { 30, 31, 29, 32, 28, 27, 30, 25 };
      for (int i = 0; i < arr.Length; i++) {
         for (int j = i + 1; j < arr.Length; j++) {
            if (arr[i] > arr[j]) {
               Console.WriteLine (j);
               break;
            }
         }
      }
   }
}