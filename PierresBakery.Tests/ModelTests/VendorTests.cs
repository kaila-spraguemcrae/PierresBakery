using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnVendorName_String()
    {
      string name = "Mary's Bakery";
      Vendor testVendor = new Vendor(name, "test");
      Assert.AreEqual(name, testVendor.Name);
    }
    [TestMethod]
    public void GetDescription_ReturnVendorDescription_String()
    {
      string description = "Small local cafe";
      Vendor testVendor = new Vendor("test", description);
      Assert.AreEqual(description, testVendor.Description);
    }
  }
}