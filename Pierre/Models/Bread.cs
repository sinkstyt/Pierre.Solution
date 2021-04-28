using System.Collections.Generic;

namespace Pierre.Models

{
  public class Bread
  {
    public int LoavesInOrder { get; set; }
    public int CostPerLoaf = 5;
    private static List<Bread> _allBreads = new List<Bread> {};
    
    public Bread(int loavesInOrder)
    {
      LoavesInOrder = loavesInOrder;
      _allBreads.Add(this);
    }

    public static int PriceOfLoaves()
    {
      int SubTotal = 0;
      int allLoavesCount = 0;
      foreach (Bread order in _allBreads)
      {
        allLoavesCount += order.LoavesInOrder;
        SubTotal += order.CostPerLoaf * order.LoavesInOrder;
      }
      // if (allLoavesCount >= 2) buy 2, get 1 free
      // {
      //   apply discount
      // }

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

    public static void ClearAll()
    {
      _allBreads.Clear();
    }
  }
}