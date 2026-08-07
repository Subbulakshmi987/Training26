/// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------------------------------
// Program.cs
// Program to check whether a given matrix is a magic square.
// ------------------------------------------------------------------------------------------------
namespace Training26;

class Program {
   static void Main () {
      int[,] matrix = {
         { 2, 7, 6 },
         { 9, 5, 1 },
         { 4, 3, 8 }
      };
      Console.WriteLine (IsMagicSquare (matrix));
   }
   
   /// <summary>Returns whether the matrix is Magicmatrix</summary>
   static bool IsMagicSquare (int[,] matrix) {
      int magicSum = 0, diagonal1 = 0, diagonal2 = 0;
      for (int j = 0; j < 3; j++) magicSum += matrix[0, j];
      for (int i = 0; i < 3; i++) {
         int rowSum = 0, columnSum = 0;
         for (int j = 0; j < 3; j++) {
            rowSum += matrix[i, j]; 
            columnSum += matrix[j, i];
         }
         if (magicSum != rowSum || magicSum != columnSum) return false;
         diagonal1 += matrix[i, i];
         diagonal2 += matrix[i, 3 - 1 - i];
      }
      return diagonal1 == magicSum && diagonal2 == magicSum;
   }
}