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
      // MainMenu();
      // CartShow();
    // Prompt for adding baked good to cart, View cart and Total, or Quit

    // Add baked good to cart: Use branching to ask for number of ${re-displayed-selection}

    // Pass number of Breads.WithType through price calculator and add to OrderTotal
    
    // Cart Show: Print to Console all OrderDetails including TotalOrder for Price

    // Call Main to get back to top of Main Menu
    }

    static void MainMenu()
    {

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
      WriteAsterisksLine("******");
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