//  foravg.cs Using the for statement.
//  print the average of 10 random numbers that are from 1 to 10.
//----------------------------------------------------------------

class average
{
   public static void Main()
   {
      int ttl = 0;  // variable to store the running total
      int nbr = 0;  // variable for individual numbers
      int ctr = 0;  // counter
      
      System.Random rnd = new System.Random();  // random number
 
      for ( ctr = 1; ctr <= 10; ctr++ )
      {
          //Get random number
          nbr = (int) rnd.Next(1, 11); 
 
          System.Console.WriteLine("Number {0} is {1}", (ctr), nbr);
 
          ttl += nbr;        //add nbr to total
      }

      System.Console.WriteLine("\nThe total of the 10 numbers is {0}", ttl);
      System.Console.WriteLine("\nThe average of the numbers is {0}", ttl/10 );
   }
}
