namespace Training_26 {
   class Program2 {
      static void Main () {
         int[,] matrix =
         {
                 {2, 7, 6},
                 {9, 5, 1},
                 {4, 3, 8}

        };
         int magicSum = 0;

         for (int j = 0; j < 3; j++) {
            magicSum += matrix[0, j];
         }
         bool Ismagic = false;
         for (int i = 0; i < matrix.GetLength (0); i++) {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength (1); j++) {
               sum += matrix[i, j];
            }

            if (magicSum == sum) {
               Ismagic = true;
            }
         }

         for (int j = 0; j < matrix.GetLength (1); j++) {
            int columnsum = 0;
            for (int i = 0; i < matrix.GetLength (1); i++) {
               columnsum += matrix[j, i];
            }

            if (magicSum == columnsum) {
               Ismagic = true;
            }
         }
         int diagonal1 = 0;
         for (int i = 0; i < 3; i++) {
            diagonal1 += matrix[i, i];

         }
         if (magicSum == diagonal1) {
            Ismagic = true;
         }
         int diagonal2 = 0;
         for (int i = 0; i < 3; i++) {
            diagonal2 += matrix[i, 2 - i];

         }
         if (magicSum == diagonal1) {
            Ismagic = true;
         }
         if (Ismagic) {
            Console.WriteLine ("True");
         } else {
            Console.WriteLine ("False");
         }


      }
   }


}

