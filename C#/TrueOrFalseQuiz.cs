// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // This is a True or False quiz which will repeat questions if the required answer format is not met
      // Welcome the user and ask them to press enter when they would like to start
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Create 3 Arrays containing the questions, their corresponsing answers, and the users responses.      
      string[] questions = {"Marrakesh is the capital of Morocco", "\nA lion's roar can be heard up to eight kilometres away", "\nThere are 219 episodes of Friends", "\nThere are two parts of the body that can't heal themselves", "\nAustralia is wider than the moon"};
      bool[] answers = {false, true, false, false, true};
      bool[] responses = new bool[5];

      // Check there are the same amount of questions as there are answers
      if (questions.Length != answers.Length)
      {
        Console.Write("WARNING! The amount of Questions and Answers are not equal.");
      }

      // Create index to know what question is being asked
      int askingIndex = 0;

      // Foreach to loop through each question in the array
      foreach (string question in questions)
      {
        // Define variables
        string input;
        bool isBool;
        bool inputBool;

        // Ask the current question
        Console.WriteLine(question);
        Console.Write("True or False?: - \n");
        // Store the reply as the input
        input = Console.ReadLine();
        // Check whether the reply can be turned into a boolean value - True or False
        isBool = Boolean.TryParse(input, out inputBool);

        // Check if it was changed into a boolean value
        while (isBool == false) 
        {
          // If the input was not turned into a boolean value, ask the user to input their answer again
          Console.Write("Please Respond with 'true' or 'false': -\n");
          input = Console.ReadLine();
          // Try parse the input again if still not correct input ask again until the user complies
          isBool = Boolean.TryParse(input, out inputBool);
        }

        // Add the response to the responses array after it has been confirmed to be the correct format
        responses[askingIndex] = inputBool;
        // increment the askingIndex by 1
        askingIndex ++;
      }
      
      // Create variables to store scoring data
      int scoringIndex = 0;
      int score = 0;

      // Loop through the answers in array to compare with the users response
      foreach(bool answer in answers)
      {

        bool response = responses[scoringIndex];
        Console.WriteLine("\n" + (scoringIndex + 1) + ". Input: " + response + " | Answer: " + answer);

        // if the response and answer are the same add 1 to the score
        if (response == answer)
        {
          score ++;
        }

        // Add 1 to the scoring index to move to the next instance
        scoringIndex ++;
      }

      // Print out the final scores
      Console.WriteLine("You got " + score + " out of " + scoringIndex+ " correct!");
    }
  }
}
