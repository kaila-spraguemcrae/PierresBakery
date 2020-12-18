using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>{};
      _instances.Add(this);
      Id = _instances.Count;
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-2];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}