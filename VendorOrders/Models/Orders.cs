using System;
using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public double Price {get; set;}
    public DateTime Date {get; set;}
    private static List<Order> _instances = new List<Order>{};
    public int Id {get;set;}

    public Order(string title, string description, double price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}