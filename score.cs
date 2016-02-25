//  score.cs    Using the goto and label statements.
//  Disclaimer: This program shows the use of goto and label
//              This is not a good use; however, it illustrates
//              the functionality of these keywords.
//--------------------------------------------------------------------
 
class score
{
   public static void Main()
   {
      int score = 0;
      int ctr = 0;
 
      System.Random rnd = new System.Random();
 
      Start:
 
      ctr++;   
 
      if (ctr > 10)
          goto EndThis;
      else
          score = (int) rnd.Next(60, 101);
  
      System.Console.WriteLine("{0} - You received a score of {1}", 
                   ctr, score);
 
      goto Start;
           
     EndThis:
 
      System.Console.WriteLine("Done with scores!");
   }
}
