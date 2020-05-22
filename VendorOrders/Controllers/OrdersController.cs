using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

    
  }
}
