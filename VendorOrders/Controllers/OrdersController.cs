using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult New()
    {
      return View("New");
    }

    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult Create(string title, string description, double price, DateTime date, int Id)
    {
      
      return RedirectToAction("Show", "Vendors", Id);
    }
  }
}
