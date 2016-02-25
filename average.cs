//  average.cs Using the while statement.
//  print the average of 10 random numbers that are from 1 to 10.
//---------------------------------------------------------------
 
class average
{
   public static void Main()
   { 
      int ttl = 0;  // variable to store the running total
      int nbr = 0;  // variable for individual numbers
      int ctr = 0;  // counter
       
      System.Random rnd = new System.Random();  // random number
 
      while ( ctr < 10 )
      {
          //Get random number
          nbr = (int) rnd.Next(1,11); 
 
          System.Console.WriteLine("Number {0} is {1}", (ctr + 1), nbr);

          ttl += nbr;        //add nbr to total
          ctr++;             //increment counter
      }
 
      System.Console.WriteLine("\nThe total of the {0} numbers is {1}", ctr, ttl);
      System.Console.WriteLine("\nThe average of the numbers is {0}", ttl/ctr );
   }
}
