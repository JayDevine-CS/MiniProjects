using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm storm = new Storm("wind", false, "Zul'rajas");
      storm.Announce();   

      Pupil pupil1 = new Pupil("Mezil-kree");
      Storm storm1 = pupil1.CastWindStorm();

      storm1.Announce();

      Mage mage1 = new Mage("Gul'dan");
      Storm storm2 = mage1.CastRainStorm();

      storm2.Announce();

      Archmage archmage1 = new Archmage("Nielas Aran");
      Storm storm3 = archmage1.CastRainStorm();
      Storm storm4 = archmage1.CastLightningStorm();

      storm3.Announce();
      storm4.Announce();
    }
  }
}