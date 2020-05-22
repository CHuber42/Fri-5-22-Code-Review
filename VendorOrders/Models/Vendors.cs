using System;
using System.Collections.Generic;

namespace VendorOrders.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public int Id {get; set;}
    private static List<Vendor> _instances = new List<Vendor>{}; 
    public List <Order> Orders {get; set;}
    public int TargetOrder {get; set;}
    public Vendor(string name)
    {
      _instances.Add(this);
      Id = _instances.Count;
      Name = name;
      Orders = new List<Order>{};
      TargetOrder = 0;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int id)
    {
      return _instances[id - 1];
    }

    public void AddOrder(Order newOrder)
    {
      Orders.Add(newOrder);
    }
  }
}