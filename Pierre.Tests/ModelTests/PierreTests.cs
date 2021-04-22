using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre;

namespace Pierre.Tests
{
  [TestClass]
  public class PierreTests
  {
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // testing code found here
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceWhoseTypeIsBread_Bread()
    {
      Bread FreshLoaf = new Bread(1);
      Assert.AreEqual(typeof(Bread), FreshLoaf.GetType());
    }
  }
}
