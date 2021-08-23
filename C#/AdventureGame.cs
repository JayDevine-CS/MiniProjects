// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace ChooseYourOwnAdventure
{
  class AdventureGame
  {
      static void Main(string[] args)
    {
      // THE MYSTERIOUS NOISE - Text Adventure Game

      // Asking the user for their name and welcoming them

      Console.Write("What is your name?:\n");
      string name = Console.ReadLine();
      Console.WriteLine($"\nHello, {name}! Welcome to our story.\n");

      // Start telling the story

      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\n");

      // Ask the user to make a decision and use it to decide next step
      Console.Write(" - Type YES or NO:\n");
      string noiseChoice = Console.ReadLine();
      // Ensure choice is in uppercase to reduce chance of error
      noiseChoice = noiseChoice.ToUpper();

      // Conditional Statement to output different text depending on answer
      if (noiseChoice == "NO") // End of story if user chooses NO
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!\n\nTHE END.\n");
      }
      else if (noiseChoice == "YES") // Carry on with story if user selects Yes
      {

        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?\n");
        Console.Write(" - Type OPEN or KNOCK:\n");
        string doorChoice = Console.ReadLine(); // Store next choice
        doorChoice = doorChoice.ToUpper();

        // Use users choice to direct the story
        if (doorChoice == "KNOCK")
        {

          Console.WriteLine("A voice behind the door speaks.\nIt says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"\n");
          Console.Write(" - Type your answer:\n");
          string riddleAnswer = Console.ReadLine();
          riddleAnswer = riddleAnswer.ToUpper();

          if (riddleAnswer == "NOTHING")
          {
            Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\n\nTHE END.");
          }
          else
          {
            Console.WriteLine("You answered incorrectly.\nThe door doesn't open.\n\nTHE END.");
          }
        }
        else if (doorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.\n");
          Console.Write("Enter a number (1-3):\n");
          string keyChoice = Console.ReadLine();
          keyChoice = keyChoice.ToUpper();
          
          // Switch case to give different outcomes depending what the user had inputted
          switch (keyChoice)
          {
            case "1":
              Console.WriteLine("You choose the first key.\nLucky choice!\nThe door opens and NOTHING is there.\n Strange...\n\nTHE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key.\nThe door doesn't open.\n\nTHE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key.\nThe key disappears when put into the lock.\n\nTHE END.");
              break;
            default:
              Console.WriteLine("You did not choose a key.\nThe door doesn't open.\n\nTHE END.");
              break;
          }
        }
      }
    }
  }
}


