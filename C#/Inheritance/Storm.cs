// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm
  {
    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    public string Essence
    { get; private set; }

    public bool IsStrong
    { get; private set; }

    public string Caster
    { get; private set; }

    public void Announce()
    {
      if (IsStrong == true)
      {
        Console.WriteLine($"{Caster} cast a strong {Essence} storm!");
      }
      else 
      {
        Console.WriteLine($"{Caster} cast a weak {Essence} storm!");
      }
    }
  }
}