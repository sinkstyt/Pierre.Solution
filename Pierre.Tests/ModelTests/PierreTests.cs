using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;

namespace Pierre.Tests
{
  [TestClass]
  public class PierreTests
  {
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

    // [TestMethod]
    // public void PriceOfBreads_ReturnsIntegerMeaningPriceWhileLoavesInOrderIs1_5()
    // {
    //   int orderSize = 1;
    //   Bread SmallOrder = new Bread(orderSize);
    //   int expectedPrice = 5;
    //   int received = SmallOrder.PriceOfLoaves();
    //   Assert.AreEqual(expectedPrice, received);
    // }
  }
}
