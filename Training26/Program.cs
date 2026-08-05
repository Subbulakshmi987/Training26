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
         {2,7,6 },
         {9,5,1 },
         {4,3,8 }
      };
      Console.WriteLine (IsMagicSquare (matrix));
   }
   static bool IsMagicSquare (int[,] matrix) {
      int diagonal1 = 0, magicSum = 0,rowSum=0,columnSum=0, diagonal2 = 0;
      for (int j = 0; j < 3; j++) magicSum += matrix[0, j];
      for (int i = 0; i < 3; i++) {
         for (int j = 0; j < 3; j++) 
            rowSum += matrix[i, j];
         if(magicSum != rowSum) return false;
      }
      for (int j = 0; j < 3; j++) {
         for (int i = 0; i < 3; i++)
            columnSum += matrix[i, j];
         if(magicSum != columnSum) return false;
      }
      for (int i = 0; i < 3; i++) diagonal1 += matrix[i, i];
      if(magicSum != diagonal1) return false;
      for (int i = 0; i < 3; i++)
         diagonal2 += matrix[i, 3- 1 - i];
      if(magicSum != diagonal2) return false;
      return true;
   }
}