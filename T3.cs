using System;
using System.Collections.Generic;
using System.Text;

namespace Training_26 {
   internal class T3 {
      static void Main () {
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
}
