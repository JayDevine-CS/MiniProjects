// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace MadLibs
{
  class MadLibGenerator
  {
    static void Main(string[] args)
    {
      //This program allows the user to input their own words to create a MadLibs Story.
      
      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to this MadLibs Application. Have fun!");

      // Give the Mad Lib a title:
      string title = "A Good Day:";

      Console.WriteLine(title);
      // Ask user for each element of MadLib Story and store within variables:
      Console.WriteLine("- What is your name?");
      string name = Console.ReadLine();

      Console.WriteLine("- Please enter an adjective (Describes a Noun)");
      string adj1 = Console.ReadLine();

      Console.WriteLine("- Please enter another adjective (Describes a Noun)");
      string adj2 = Console.ReadLine();

      Console.WriteLine("- Please enter another adjective (Describes a Noun)");
      string adj3 = Console.ReadLine();

      Console.WriteLine("- Please enter a verb (Represents an Action)");
      string verb = Console.ReadLine();

      Console.WriteLine("- Please enter a noun (Name of something: Person, Object, Place))");
      string noun1 = Console.ReadLine();

      Console.WriteLine("- Please enter a noun (Name of something: Person, Object, Place)");
      string noun2 = Console.ReadLine();

      Console.WriteLine("- Please enter an Animal");
      string animal = Console.ReadLine();
      
      Console.WriteLine("- Please enter a Food");
      string food = Console.ReadLine();

      Console.WriteLine("- Please enter a fruit");
      string fruit = Console.ReadLine();

      Console.WriteLine("- Please enter a Superhero");
      string hero = Console.ReadLine();

      Console.WriteLine("- Please enter a Country");
      string country = Console.ReadLine();

      Console.WriteLine("- Please enter a Dessert");
      string dessert = Console.ReadLine();

      Console.WriteLine("- Please enter a Year");
      string year = Console.ReadLine();

      // The template for the story:
      // Add variables into story using interpolation
      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
