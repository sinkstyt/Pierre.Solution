using System.Collections.Generic;
using System;

namespace Pierre.Models
{
  public class Pastry
  {
    public int PastryCount { get; set; }
    public int CostPerPastry = 2;
    private static List<Pastry> _allPastries = new List<Pastry> {};

    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
      _allPastries.Add(this);
    }

    public static int PriceOfPastries()
    {
      int pastryCost = 0;
      int countOfAllPastries = 0;
      foreach (Pastry instance in _allPastries)
      {
        countOfAllPastries += instance.PastryCount;
        pastryCost += instance.PastryCount * instance.CostPerPastry;
      }
      if (countOfAllPastries >= 3)
      {
        int groupsOfThree = Convert.ToInt32(Math.Floor((decimal)countOfAllPastries / 3 ));
        pastryCost -= groupsOfThree;
      }
      return pastryCost;
    }
    
    public static void ClearAll()
    {
      _allPastries.Clear();
    }
  }
}