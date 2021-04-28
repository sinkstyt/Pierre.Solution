using System.Collections.Generic;

namespace Pierre.Models

{
  public class Bread
  {
    public int LoavesInOrder { get; set; }
    public int CostPerLoaf = 5;
    
    public Bread(int loavesInOrder)
    {
      LoavesInOrder = loavesInOrder;
    }

    public static int PriceOfLoaves()
    {
      int SubTotal = 0;
      // GetAllBreads() gathers all instances of Bread

      // iterate through all Breads, add calculated price of breads to SubTotal each time through

      // return SubTotal after loop
      return SubTotal;
    }

    public static List<Bread> GetAllBreads()
    {
      // List<string> groceryList = new List<string> {};
      List<Bread> allBreads = new List<Bread>{};
      
      return allBreads;
    }
  }
}