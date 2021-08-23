// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace MoneyMaker
{
  class CoinCalculator
  {
    public static void Main(string[] args)
    {
      // Informing User of what is happening and taking input of amount.
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please enter an amount in cents you would like to split into Coins: \nGold(10), Silver(5) and Bronze(1) Coins:");
      string amount = Console.ReadLine();
      double coinAmount = Convert.ToDouble(amount);
      Console.WriteLine($"{coinAmount} cents is equal to...");

      // Setting values for each coin
      int gold = 10;
      int silver = 5;

      // Find the maximum amount of gold coins that fit into amount.
      double goldCoinsInAmount = coinAmount / gold;
      double goldCoins = Math.Floor(goldCoinsInAmount);
      
      // Find the remainder from the gold coins.
      double remainder = coinAmount % gold;

      // Find the maximum amount of silver coins that fit into remainder.
      double silverCoinsInAmount = remainder / silver;
      double silverCoins = Math.Floor(silverCoinsInAmount);

      // Find the remainder from the silver coins.
      remainder = remainder % silver;

      // Print Values of coins
      Console.WriteLine($"Gold Coins : {goldCoins} \n Silver Coins : {silverCoins} \n Bronze Coins : {remainder}");
    }
  }
}
