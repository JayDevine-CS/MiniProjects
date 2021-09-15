using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      // Todo List Instance
      TodoList tdl = new TodoList();
      // Add tasks into Todo Array
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      
      
      
      // Password Manager Instance
      PasswordManager pm = new PasswordManager("iluvpie", true);

      tdl.Display();
      pm.Display();

      tdl.Reset();
      pm.Reset();
    }
  }
}
