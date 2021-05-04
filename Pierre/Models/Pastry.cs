using System.Collections.Generic;
using System;

namespace Pierre.Models
{
  public class Pastry
  {
    public int PastryCount { get; set; }
    public int CostPerPastry = 2;
    private static List<Pastry> _allPastries = new List<Pastry> {};
    public int TotalPastriesCost { get; }
    public int AllPastriesCount { get; }

    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
      _allPastries.Add(this);
    }

    public static int PriceOfPastries()
    {
      int TotalPastriesCost = 0;
      int AllPastriesCount = 0;
      foreach (Pastry instance in _allPastries)
      {
        AllPastriesCount += instance.PastryCount;
        TotalPastriesCost += instance.PastryCount * instance.CostPerPastry;
      }
      if (AllPastriesCount >= 3)
      {
        int groupsOfThree = Convert.ToInt32(Math.Floor((decimal)AllPastriesCount / 3 ));
        TotalPastriesCost -= groupsOfThree;
      }
      return TotalPastriesCost;
    }

    public static List<Pastry> GetAllPastries()
    {
      return _allPastries;
    }
    
    public static void ClearAll()
    {
      _allPastries.Clear();
    }
  }
}