using System;
using Rock.Models;

namespace Rock
{
  class Program
  {
    static void Main( )
    {
      Console.WriteLine("Welcome to the Rock Scissor Paper Game!");
      Console.WriteLine("We'll start. Ready? Go!");
      Console.WriteLine("Please enter : 'rock', 'scissor', or 'paper' . ");

      string player1 = Console.ReadLine();  
      Console.WriteLine("Enter another:");
      string player2 = Console.ReadLine();  
    
      RockGame game = new RockGame(player1, player2);
      // Console.WriteLine(game.RPSGame());
    }

    // static void ConfirmOrEditTriangle(Triangle tri)
    // {
    //   // Console.WriteLine("Please confirm that you entered in your triangle correctly:");
    //   // Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
  
    //   // Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
    //   // string userInput = Console.ReadLine();  
    //   // if (userInput == "yes")
    //   // {
    //   //   CheckTriangleType(tri);
    //   // }
    //   // else
    //   // {
    //   //   Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
    //   //   Console.WriteLine("Please enter a number:");
    //   //   string stringNumber1 = Console.ReadLine();  
   
    //   //   tri.Side1 = int.Parse(stringNumber1);  
    //   //   ConfirmOrEditTriangle(tri);
    //   // }
    // }

    // static void CheckTriangleType(Triangle tri)
    // {
    //   string result = tri.CheckType();
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("Your result is: " + result + ".");
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("What's next?");
    //   Console.WriteLine("Would you like to check a new triangle (new)?");
    //   Console.WriteLine("Please enter 'new' to check the type of a new triangle. To exit, enter any key.");
    //   string userResponse = Console.ReadLine(); 
    //   if (userResponse == "new" || userResponse == "New")
    //   {
    //     Main();
    //   }
    //   else
    //   {
    //     Console.WriteLine("Goodbye!");
    //   }
    // }
  }
}