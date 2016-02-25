//  Names.cs. Exercise 7 for Day 4
//--------------------------------------------------------------------

class Names
{
   public static void Main()
   {
      string name = "Kalee";

      System.Console.WriteLine("Starting the switch... {0}", name);

      switch (name)
      {
          case "Robert":
                    System.Console.WriteLine("Hi Bob!");
                    break;
          case "Richard":
                    System.Console.WriteLine("Hi Rich!");
                    break;
          case "Barbara":
                    System.Console.WriteLine("Hi Barb!");
                    break;
          case "Kalee":
                    System.Console.WriteLine("You Go Girl!");
                    break;
          default:
                    System.Console.WriteLine("Hi {0}", name);
                    break;
      }
      System.Console.WriteLine("The switch statement is now over!");
   }
}
