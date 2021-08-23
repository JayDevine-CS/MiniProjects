// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome User and ask which mode they would like to use
      Console.WriteLine("Hello and welcome to this Ceaser Cipher Application -\n\n ");
      Console.WriteLine("Please Select whether you would like to Encrypt or Decrypt a message:\n");
      Console.Write("Type:\n 1 - Encrypt\n 2 - Decrypt\n\n");
      string gameMode = Console.ReadLine();
      
      // Continue depending on which mode was selected
      if (gameMode == "1")
      {
        // Ask the user to enter their message
        Console.Write("\nPlease enter a message you would like to encrypt: -\n");
        string userMessage = Console.ReadLine()
        
        // Ensure all characters are lower case and add to array
        userMessage = userMessage.ToLower();
        char[] secretMessage = userMessage.ToCharArray();
        
        // Ask the user to choose the key they would like to use
        Console.Write("\nPlease enter an encryption key you would like to use: -\n");
        string encryptionKey =  Console.ReadLine();
        int key = Int32.Parse(encryptionKey); // Convert the answer from string to int

        // Run Encrypt method
        Encrypt(secretMessage, key);

      } 
      else if (gameMode == "2")
      {
        // Ask the user to enter their message
        Console.Write("\nPlease enter a message you would like to decrypt: -\n");
        string userMessage = Console.ReadLine();

        // Ensure all characters are lower case and add to array
        userMessage = userMessage.ToLower();
        char[] encryptedMessage = userMessage.ToCharArray();
        
        // Ask the user to choose the key they would like to use
        Console.Write("\nPlease enter an decryption key you would like to use: -\n");
        string decryptionKey =  Console.ReadLine();
        int key = Int32.Parse(decryptionKey);

        // Run Decrypt method
        Decrypt(encryptedMessage, key);
      }
      else 
      {
        // Error catchment incase no mode was selected
        Console.WriteLine("\nYou have not selected a valid mode. Please Try Again.\n");
      } 
    }

    // Encryption method
    static void Encrypt(char[] secretMessage, int key = 3)
    {
      // Alphabet array to find index of letters
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      // Find message length and create output array of the same length
      int msgLength = secretMessage.Length;
      char[] encryptedMessage = new char[msgLength];

      // For loop to iterate through characters in message
      for (int i = 0; i < msgLength; i++)
      {
        char letter = secretMessage[i];
        // Check if letter is a character and not a symbol
        if (Char.IsLetter(letter))
        {
          int index = Array.IndexOf(alphabet, letter);
          // Ensures that if the index goes above or below the length of the alphabet it is fixed using modulo
          int encryptedIndex = (index + key) % alphabet.Length;
          // Finds letter in alphabet using index
          char encryptedLetter = alphabet[encryptedIndex];
          // Adds the letter into the message
          encryptedMessage[i] = encryptedLetter;
        }
      }

      // Join each character together to create a string message
      string cipheredMessage = String.Join("", encryptedMessage);
      // Print combined string
      Console.WriteLine("\nYour Encrypted Message is: - \n" + cipheredMessage);
    }
  
    // Decryption Method
    static void Decrypt(char[] encryptedMessage, int key = 3)
    {
      // Alphabet array to find index of letters
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      // Find message length and create output array of the same length
      int msgLength = encryptedMessage.Length;
      char[] secretMessage = new char[msgLength];

      // For loop to iterate through characters in message
      for (int i = 0; i < msgLength; i++)
      {
        char letter = encryptedMessage[i];
        // Check if letter is a character and not a symbol
        if (Char.IsLetter(letter))
        {
          int index = Array.IndexOf(alphabet, letter);
          // Ensures that if the index goes above or below the length of the alphabet it is fixed using modulo
          int decryptedIndex = (index - key) % alphabet.Length;
          // Finds letter in alphabet using index
          char decryptedLetter = alphabet[decryptedIndex];
          // Adds the letter into the message
          secretMessage[i] = decryptedLetter;
        }
      }

      // Join each character together to create a string message
      string decipheredMessage = String.Join("", secretMessage);
      // Print combined string
      Console.WriteLine("\nYour Decrypted Message is: - \n" + decipheredMessage);
    }
  }
}