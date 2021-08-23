// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace PasswordChecker
{
  class PasswordChecker
  {
    public static void Main(string[] args)
    {
      // This application tells the user how strong a password is depending on some preset requirements.

      // Declare requirements for passwords
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefhijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!£$%&*@-=+/.,:";

      // Ask the user to input a password and save it to a variable
      Console.WriteLine("Please Enter a Password:\n-is at least 8 characters long\n-has lowercase letters\n-has uppercase letters\n-has numerical digits\n-has symbols, like #, ?, !");
      string password = Console.ReadLine();

      // Create the variable score to store how strong the password is
      int score = 0;

      // Add a point to the score if a requirement is met
      if (password.Length >= minLength)
      {
        score += 1;
      }
      
      if (Tools.Contains(password, uppercase))
      {
        score += 1;
      }
      
      if (Tools.Contains(password, lowercase))
      {
        score += 1;
      }
      
      if (Tools.Contains(password, digits))
      {
        score += 1;
      }
      
      if (Tools.Contains(password, specialChars))
      {
        score += 1;
      }

      // Check if password is the same as some commonly used passwords
      if (password == "password" || password == "1234")
      {
        score = 0;
      }

      // Create a switch case to show the user how strong their password is depending on their score
      switch (score)
      {
        case 1:
          Console.WriteLine("Your Password Strength is: Weak");
          break;
        case 2:
          Console.WriteLine("Your Password Strength is: Medium");
          break;
        case 3:
          Console.WriteLine("Your Password Strength is: Strong");
          break;
        case 4:
          Console.WriteLine("Your Password Strength is: Very Strong");
          break;
        case 5:
          Console.WriteLine("Your Password Strength is: Very Strong");
          break;
        default:
          Console.WriteLine("Your Password does'nt meet any requirements or is commonly used.");
          break;
      }
    }
  }
}
