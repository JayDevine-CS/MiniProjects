// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Introduce the user to the application
      Console.WriteLine("Welcome to the Build a Creature Application!");
      Console.WriteLine("First, please select whether you would like to choose the features or have them randomly generated...");
      // Ask the user which mode they would like to use
      Console.Write("Type:\n 1 - Choose Yourself!\n 2 - Random!\n");
      string gameModeChoice = Console.ReadLine();

      // Continue depending on game mode selected by user
      // Choice 1 allows the user to pick each component
      if (gameModeChoice == "1")
      {

        Console.WriteLine("\nYou have selected to choose yourself...\n");
        Console.WriteLine("\nAlso if you do not select a style one will be randomly selected for you!...\n");

        // Take inputs from user which select what creature they would like to make
        Console.WriteLine("Lets begin by choosing what Head you would like your creature to have...\n");
        Console.Write("Type:\n - monster\n - ghost\n - bug\n");
        string headChoice = Console.ReadLine();

        Console.WriteLine("Next, lets choose what Body you would like your creature to have...\n");
        Console.Write("Type:\n - monster\n - ghost\n - bug\n");
        string bodyChoice = Console.ReadLine();

        Console.WriteLine("Finally, lets choose what Feet you would like your creature to have...\n");
        Console.Write("Type:\n - monster\n - ghost\n - bug\n");
        string feetChoice = Console.ReadLine();

        // Run method with the selected creature's features as the arguments 
        BuildACreature(headChoice, bodyChoice, feetChoice);

        Console.WriteLine("\nWell Done you have created your Creature!");
        choice = true;
      }
      // Randomly Generate a Creature
      else if (gameModeChoice == "2")
      {
        Console.WriteLine("You have selected to randomly create a creature...\n");
        RandomMode();
        Console.WriteLine("\nWell Done you have randomly created a Creature!");
        choice = true;
      }
      // Error catchment incase the user does not select 1 or 2
      else 
      {
        Console.WriteLine("You have not selected a game mode! Please Try Again.");
      }
    }

    // Manual Creation of Creature
    static void BuildACreature(string head, string body, string feet)
    {
      // Takes in creature selection from user and translates them to numbers  
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);

      // The numbers are then used in a Switch Case which runs required methods to create desired creature
      SwitchCase(headNum, bodyNum, feetNum);
    }

    // Switch Case takes in an integer and runs the related method to create the creature
    static void SwitchCase(int head, int body, int feet)
    {
      switch (head)
      {
        case 1:
          MonsterHead();
          break;
        case 2:
          GhostHead();
          break;
        case 3:
          BugHead();
          break;
        case 4:
          Random randomNumber = new Random();
          int randomHead = randomNumber.Next(1,4);
          switch (randomHead)
          {
            case 1:
              MonsterHead();
              break;
            case 2:
              GhostHead();
              break;
            case 3:
              BugHead();
              break;
          }
          break;
      }
      
      switch (body)
      {
        case 1:
          MonsterBody();
          break;
        case 2:
          GhostBody();
          break;
        case 3:
          BugBody();
          break;
        case 4:
          Random randomNumber = new Random();
          int randomBody = randomNumber.Next(1,4);
          switch (randomBody)
          {
            case 1:
              MonsterBody();
              break;
            case 2:
              GhostBody();
              break;
            case 3:
              BugBody();
              break;
          }
          break;
      }

      switch (feet)
      {
        case 1:
          MonsterFeet();
          break;
        case 2:
          GhostFeet();
          break;
        case 3:
          BugFeet();
          break;
        case 4:
          Random randomNumber = new Random();
          int randomFeet = randomNumber.Next(1,4);
          switch (randomFeet)
          {
            case 1:
              MonsterFeet();
              break;
            case 2:
              GhostFeet();
              break;
            case 3:
              BugFeet();
              break;
          }
          break;
      }
    }

    // Translates the inputs from the user into integers so they can be used within the Switch Case
    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "monster":
          return 1;
        case "ghost":
          return 2;
        case "bug":
          return 3;
        default:
          return 4;

      }
    }
  
    // Random Mode method allowing a random creature to be created by randomly generating numbers to be inputted into the switch case
    static void RandomMode()
    {
      Random randomNumber = new Random();

      int randomHead = randomNumber.Next(1,4);
      int randomBody = randomNumber.Next(1,4);
      int randomFeet = randomNumber.Next(1,4);

      SwitchCase(randomHead, randomBody, randomFeet);
    }
    
    //------------------- ASCII Art -----------------------
    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}

