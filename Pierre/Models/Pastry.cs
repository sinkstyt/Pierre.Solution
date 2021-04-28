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
  }
}