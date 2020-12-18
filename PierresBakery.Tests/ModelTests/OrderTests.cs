using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test", "test", 0);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      Order testOrder = new Order("Pastry Order", "test", 0);
      Assert.AreEqual("Pastry Order", testOrder.Title);
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description =  "Order of 20 Pastries";
      Order testOrder = new Order("test", description, 0);
      Assert.AreEqual(description, testOrder.Description);
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 34;
      Order testOrder = new Order ("test", "test", price);
      Assert.AreEqual(price, testOrder.Price);
    }
  }
}