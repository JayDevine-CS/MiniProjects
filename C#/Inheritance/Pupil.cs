// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil
  {
    public Pupil(string title)
    {
      Title = title;
    }

    public string Title
    { get; private set; }

    public Storm CastWindStorm()
    {
      Storm windStorm = new Storm("wind", false, Title);
      return windStorm;
    }
  }
}
