using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System;
using System.Collections.Generic;

namespace Pierre.Tests
{
  [TestClass]
  public class PierreTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
      Pastry.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceWhoseTypeIsBread_Bread()
    {
      Bread FreshLoaf = new Bread(1);
      Assert.AreEqual(typeof(Bread), FreshLoaf.GetType());
    }

    [TestMethod]
    public void LoavesInOrder_ReturnsIntegerMatchingLoavesOrdered_4()
    {
      int orderSize = 4;
      Bread moreBreads = new Bread(orderSize);
      int receivedNumber = moreBreads.LoavesInOrder;
      Assert.AreEqual(4, receivedNumber);
    }

    [TestMethod]
    public void PriceOfBreads_ReturnsIntegerWhenLoavesInOrderIs1_4()
    {
      int orderSize = 1;
      Bread justALoaf = new Bread(orderSize);
      int price = Bread.PriceOfLoaves();
      int expected = 5;
      Assert.AreEqual(expected, price);
    }

    [TestMethod]
    public void PriceOfBreads_ReturnsAccuratePriceWhenLoavesInOrderIs5_20()
    {
      int orderSize = 5;
      Bread forHungryPerson = new Bread(orderSize);
      int expectedPrice = 20;
      int received = Bread.PriceOfLoaves();
      Assert.AreEqual(expectedPrice, received);
    }

    [TestMethod]
    public void GetAllBreads_ReturnsListOfAllBreadsInstantiated_ListOfAllBreads()
    {
      int firstOrder = 3;
      int secondOrder = 4;
      Bread earlyRiser = new Bread(firstOrder);
      Bread nextPlease = new Bread(secondOrder);
      List<Bread> expectedList = new List<Bread> { earlyRiser, nextPlease };
      List<Bread> result = Bread.GetAllBreads();
      CollectionAssert.AreEqual(expectedList, result);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceWhoseTypeIsPastry_Pastry()
    {
      Pastry Danish = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), Danish.GetType());
    }

    [TestMethod]
    public void GetPastryCount_ReturnsIntegerMatchingPastriesOrdered_31()
    {
      int orderSize = 31;
      Pastry wholeLottaPastries = new Pastry(orderSize);
      int receivedNumber = wholeLottaPastries.PastryCount;
      Assert.AreEqual(31, receivedNumber);
    }

    [TestMethod]
    public void PriceOfPastries_ReturnsAccuratePriceOfOnePastry_2()
    {
      int pastriesDesired = 1;
      Pastry ordered = new Pastry(pastriesDesired);
      int expectedPrice = 2;
      int result = Pastry.PriceOfPastries();
      Assert.AreEqual(expectedPrice, result);
    }

    [TestMethod]
    public void PriceOfPastries_ReturnsAccuratePriceIntegerWhenPastriesInOrderIs17_29()
    {
      int pastriesCraved = 17;
      Pastry ordered = new Pastry(pastriesCraved);
      int expectedPrice = 29;
      int result = Pastry.PriceOfPastries();
      Assert.AreEqual(expectedPrice, result);
    }
  }
}
