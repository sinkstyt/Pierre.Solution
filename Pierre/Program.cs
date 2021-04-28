using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre
{
  public class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("Welcome to Pierre's Bakery in the Console");
      DisplayPrices();
      ShowMainMenu();
    }

    static void ShowMainMenu()
    {
      WriteAsterisksLine("             *** Main Menu *** ");
      Console.WriteLine();      
      Console.WriteLine("To add baked goods to your order, enter 1");
      Console.WriteLine("View your cart and order total, enter 2");
      Console.WriteLine("To leave, enter anything else -- even <ENTER>");
      string userWants = Console.ReadLine();
      if (userWants == "1") {
        AddToOrder();
      }
      else if (userWants == "2")
      {
        CartShow();
      }
      else
      {
        Console.WriteLine("Until next time");
      }
    }

    static void AddToOrder()
    {
      WriteAsterisksLine(" Would you like to order loaves of bread or pastries? ");
      WriteAsterisksLine("    enter 'b' or '1' for breads");
      WriteAsterisksLine("    enter 'p' or '2' for pastries");
      Console.WriteLine();
      char userCommand = Convert.ToChar(Console.ReadLine());
      if (userCommand == Convert.ToChar("1") || userCommand == 'b' || userCommand == 'B') {
        WriteAsterisksLine("   How many loaves would you like?");
        int breadsWanted = Convert.ToInt32(Console.ReadLine());
        Bread freshLoaf = new Bread(breadsWanted);
      }
      else if (userCommand == Convert.ToChar("2") || userCommand == 'p' || userCommand == 'P')
      {
        WriteAsterisksLine("   How many pastries would you like?");
        int pastriesWanted = Convert.ToInt32(Console.ReadLine());
        Pastry freshPastry = new Pastry(pastriesWanted);
      }
      ShowMainMenu();
    }

    static void CartShow()
    {
      WriteAsterisksLine("   ****  your order  *****");
      Console.WriteLine();
      List<Bread> breads = Bread.GetAllBreads();
      List<Pastry> pastries = Pastry.GetAllPastries();
      int orderTotal = 0;
      int breadCount = 0;
      int pieCount = 0;
      foreach(Bread loaf in breads)
      {
        breadCount += loaf.LoavesInOrder;
      }
      foreach(Pastry pie in pastries)
      {
        pieCount += pie.PastryCount;
      }
      orderTotal = Pastry.PriceOfPastries();
      orderTotal += Bread.PriceOfLoaves();
      Console.WriteLine("Loaves of bread in your current order: {0}", breadCount);
      Console.WriteLine("Pastries you have ordered: {0}", pieCount);
      string priceConfirm = "   * T O T A L * for this * O R D E R *   $ "+orderTotal;
      WriteAsterisksLine(priceConfirm);
      Console.WriteLine();
      WriteAsterisksLine("  ** Does this look correct? (y or n) **");
      string looksGood = Console.ReadLine();
      if (looksGood == "y" || looksGood == "Y")
      {
        Console.WriteLine("Wonderful. Thanks for your business!");
      }
      else
      {
        ShowMainMenu();
      }
    }

    static void DisplayPrices()
    {
      WriteAsterisksLine("Here are today's prices and discounts");
      Console.WriteLine();
      WriteAsterisksLine("              ******");
      Console.WriteLine();
      WriteAsterisksLine(" ** 1 loaf of bread is $5. Buy 2 loaves and a third is included for free. ** ");
      Console.WriteLine();
      WriteAsterisksLine(" ** 1 pastry is $2. ** For three pastries: $5. ** ");
      Console.WriteLine();
    }

    static void WriteAsterisksLine(string value)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
        Console.ResetColor();
    }
  }
}