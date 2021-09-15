using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    // Defining Properties and nextOpenIndex counter
    public string[] Todos
    { get; private set; }

    public string HeaderSymbol
    { get; set; }

    private int nextOpenIndex;

    // Todo Constructor - Creates String Array, sets OpenIndex to 0
    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    // Finds Next availiable index for array and adds task into it
    // Also increments OpenIndex by 1
    public void Add(string todo)
    {
      if (nextOpenIndex < 5)
      {
        Todos[nextOpenIndex] = todo;
        nextOpenIndex++;
      }
      else
      {
        Console.WriteLine("\n-- WARNING! Too Many Tasks! Cannot add any more --");
      }
      
    }

    public void Display()
    {
      HeaderSymbol = "-";
      Console.WriteLine("\nTodos");
      Console.WriteLine(HeaderSymbol + HeaderSymbol + HeaderSymbol + HeaderSymbol + HeaderSymbol + HeaderSymbol);
      
      foreach (string task in Todos)
      {
        if (String.IsNullOrEmpty(task))
        {
          Console.WriteLine("[]");
        }
        else
        {
          Console.WriteLine(task);
        }
      }
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
  }
}