//  even.cs- Using the while with the break and continue commands.
//----------------------------------------------------------------
 
class even
{ 
   public static void Main()
   {
      int ctr = 0;
 
      while (true)
      {
         ctr++;
   
         if (ctr > 10 )
         {
            break;
         }
         else if ( (ctr % 2) == 1 )
         {
            continue;
         }
         else
         {
            System.Console.WriteLine("...{0}...", ctr);
         }
      }
      System.Console.WriteLine("Done!");
   }
}
