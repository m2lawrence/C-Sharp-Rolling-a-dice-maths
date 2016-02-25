//  allinone.cs. Exercise 6 for Day 4
//--------------------------------------------------------------------

class allinone
{
   public static void Main()
   {
      int ctr;

      // One solution:

      for (ctr = 1; ctr <= 10; System.Console.WriteLine("{0}", ctr++))
           ;  // empty statement.

      // Another solution:

      for (ctr = 0; ++ctr <= 10; System.Console.WriteLine("{0}", ctr))
           ;  // empty statement.
   }
}
