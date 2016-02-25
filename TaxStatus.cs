//  TaxStatus. Exercise 1 for Day 4 
//-------------------------------------------------------------

class TaxStatus
{
   public static void Main()
   {
      char file_type = 'm';

      if ( file_type == 's' )
      {
          System.Console.WriteLine("The filer is single");
      }
      else if ( file_type == 'm' )
      {
          System.Console.WriteLine("The filer is married filing at the single rate");
      }
      else if ( file_type == 'j' )
      {
          System.Console.WriteLine("The filer is married filing at the joint rate");
      }
      else
      {
          System.Console.WriteLine("The file type is not valid");
      }
   }
}
