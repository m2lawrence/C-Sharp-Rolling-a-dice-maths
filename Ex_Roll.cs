//  Ex_Roll.cs- Exercise 4.8. Using the switch statement.
//--------------------------------------------------------------------

class Ex_Roll
{
   public static void Main()
   {
      int roll = 0;
      int ctr = 0;
      int range = 6;

      int nbr_1 = 0;    //variables used to hold totals
      int nbr_2 = 0;
      int nbr_3 = 0;
      int nbr_4 = 0;
      int nbr_5 = 0;
      int nbr_6 = 0;

      // Create random number variable
      System.Random rnd = new System.Random();

      for (ctr = 0; ctr < 100; ctr++ )
      {
        // The next line set the roll to a random number from 1 to the 
        // value set in range

        roll = (int) rnd.Next(1, range + 1);

        System.Console.WriteLine("Roll {0} is {1}", ctr+1, roll);

        switch (roll)
        {
          case 1:
                    nbr_1++;
                    break;
          case 2:
                    nbr_2++;
                    break;
          case 3:
                    nbr_3++;
                    break;
          case 4:
                    nbr_4++;
                    break;
          case 5:
                    nbr_5++;
                    break;
          case 6:   
                    nbr_6++;
                    break;
          default:
                    System.Console.WriteLine("Roll is not 1 through 6");
                    break;
        }
     }
     System.Console.WriteLine("\n\nThe results are:");
     System.Console.WriteLine("ones:     {0}", nbr_1);
     System.Console.WriteLine("twos:     {0}", nbr_2);
     System.Console.WriteLine("threes:   {0}", nbr_3);
     System.Console.WriteLine("fours:    {0}", nbr_4);
     System.Console.WriteLine("fives:    {0}", nbr_5);
     System.Console.WriteLine("sixes:    {0}", nbr_6);
   }
}
