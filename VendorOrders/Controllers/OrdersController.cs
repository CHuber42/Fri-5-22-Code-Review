using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult New(int Id)
    {
      Vendor thisVendor = Vendor.Find(Id);
      return View("New", thisVendor);
    }

    [HttpGet("/vendors/{Id}/orders/{orderId}")]
    public ActionResult Show(int Id, int orderId)
    {
      Vendor thisVendor = Vendor.Find(Id);
      int i = 0;
      bool found = false;
      while (!found)
      {
        if (orderId == thisVendor.Orders[i].Id)
        {
          found = true;
          break;
        }
        i++;
      }
      thisVendor.TargetOrder = i;
      return View("Show", thisVendor);
    }
  }
}
