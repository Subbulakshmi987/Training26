namespace Training_26 { 
   class Program {
      static void Main (string[] args) {
         string s = "([Metamation])";
         List<int> letters = new List<int> ();
         List<int> brackets = new List<int> ();


         for (int i = 0; i < s.Length; i++) {
            if (char.IsLetter (s[i])) {
               letters.Add (s[i]);
            } else {
               brackets.Add (s[i]);
            }
         }
         foreach (int items in brackets) {

            if (items == "()" && items == "[]") {
               Console.WriteLine ("True");
            } else {
               Console.WriteLine ("False");
            }
         }



      }
   }
}


