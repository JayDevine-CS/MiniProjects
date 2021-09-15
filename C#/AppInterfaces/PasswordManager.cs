using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    
    // Defining Properties
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public string HeaderSymbol
    { get; set; }

    public void Display()
    {
      HeaderSymbol = "-";
      Console.WriteLine("\nPassword");
      Console.WriteLine(HeaderSymbol + HeaderSymbol + HeaderSymbol + HeaderSymbol + HeaderSymbol + HeaderSymbol);
      if (Hidden == false)
      {
        Console.WriteLine(Password);
      }
      else
      {
        for (int i = 0; i < Password.Length; i++)
        {
          Console.WriteLine("*");
        }
      }
    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }
    
    public bool ChangePassword(string oldPass, string newPass)
    {
      if (Password == oldPass)
      {
        Password = newPass;
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}