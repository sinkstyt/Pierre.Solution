using System.Collections.Generic;
using System;

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
        SubTotal += order.LoavesInOrder * order.CostPerLoaf;
      }
      if (allLoavesCount >= 2)
      {
        int groupsOfThree = Convert.ToInt32(Math.Floor((decimal)allLoavesCount / 3 ));
        SubTotal -= groupsOfThree * _allBreads[0].CostPerLoaf;
      }
      return SubTotal;
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