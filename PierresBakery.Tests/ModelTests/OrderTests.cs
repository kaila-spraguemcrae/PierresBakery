using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test", "test", 0, "test");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      Order testOrder = new Order("Pastry Order", "test", 0, "test");
      Assert.AreEqual("Pastry Order", testOrder.Title);
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description =  "Order of 20 Pastries";
      Order testOrder = new Order("test", description, 0, "test");
      Assert.AreEqual(description, testOrder.Description);
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int price = 34;
      Order testOrder = new Order ("test", "test", price, "test");
      Assert.AreEqual(price, testOrder.Price);
    }
    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string date = "12.18.2020";
      Order testOrder = new Order("test", "test", 0, date);
      Assert.AreEqual(date, testOrder.Date);
    }
    [TestMethod]
    public void GetAll_ReturnEmptyOrderList_OrderList()
    {
      List<Order> testList = new List<Order> {};
      CollectionAssert.AreEqual(testList, Order.GetAll());
    }
  }
}