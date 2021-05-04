using System.Collections.Generic;
using System;

namespace Pierre.Models
{
  public class Bread
  {
    public int LoavesInOrder { get; set; }
    public int CostPerLoaf = 5;
    private static List<Bread> _allBreads = new List<Bread> {};
    public int TotalBreadCost { get; }
    public int AllLoavesCount { get; }
    
    public Bread(int loavesInOrder)
    {
      LoavesInOrder = loavesInOrder;
      _allBreads.Add(this);
    }

    public static int PriceOfLoaves()
    {
      int AllLoavesCount = 0;
      int TotalBreadCost = 0;
      foreach (Bread order in _allBreads)
      {
        AllLoavesCount += order.LoavesInOrder;
        TotalBreadCost += order.LoavesInOrder * order.CostPerLoaf;
      }
      if (AllLoavesCount >= 2)
      {
        int groupsOfThree = Convert.ToInt32(Math.Floor((decimal)AllLoavesCount / 3 ));
        TotalBreadCost -= groupsOfThree * _allBreads[0].CostPerLoaf;
      }
      return TotalBreadCost;
    }

    public static List<Bread> GetAllBreads()
    {
      return _allBreads;
    }

    public static void ClearAll()
    {
      _allBreads.Clear();
    }
  }
}