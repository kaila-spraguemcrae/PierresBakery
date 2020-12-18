using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
    public static List<Order> GetAll()
    {
      Order testOrder = new Order("test", "test", 0, "test");
      List<Order> test = new List<Order>{testOrder};
      return test;
    }
  }
}