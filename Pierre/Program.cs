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

    // Pass number of Breads.WithType through price calculator and add to OrderTotal

    // Cart Show: Print to Console all OrderDetails including TotalOrder for Price

    }

    static void ShowMainMenu()
    {
      WriteAsterisksLine("             *** Main Menu *** ");
      Console.WriteLine();      
      Console.WriteLine("To add baked goods to your order, enter 1");
      Console.WriteLine("To see all baked goods ordered and order total, enter 2");
      Console.WriteLine("To leave, enter anything else -- even <ENTER>");

      string userWants = Console.ReadLine();
      if (userWants == "1") {
        AddToOrder();
      }
      else if (userWants == "2")
      {
        // ShowCart();
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
      // show all Breads and Pastries

      // Ask for correct? or make changes or start over

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