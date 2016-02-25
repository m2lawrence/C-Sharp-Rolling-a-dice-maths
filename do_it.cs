//  do_it.cs Using the do statement.
//  Get random numbers (from 1 to 10) until a 5 is reached.
//------------------------------------------------------------ 
 
class do_it
{
   public static void Main()
   {
      int ttl = 0;  // variable to store the running total
      int nbr = 0;  // variable for individual numbers
      int ctr = 0;  // counter
       
      System.Random rnd = new System.Random();  // random number
 
      do 
      {
          //Get random number
          nbr = (int) rnd.Next(1, 11); 
 
          ctr++;             //number of numbers counted
          ttl += nbr;        //add nbr to total of numbers
 
          System.Console.WriteLine("Number {0} is {1}", ctr, nbr);

      } while ( nbr != 5 );
 
      System.Console.WriteLine("\n{0} numbers were read", ctr);
      System.Console.WriteLine("The total of the numbers is {0}", ttl);
      System.Console.WriteLine("The average of the numbers is {0}", ttl/ctr );
   }
}
