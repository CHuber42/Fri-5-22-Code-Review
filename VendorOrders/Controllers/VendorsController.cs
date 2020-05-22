using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpGet("/vendors/new")]
    public ActionResult Form()
    {
      return View("Form");
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name)
    {
      Vendor newVendor = new Vendor(name);
      return RedirectToAction("Index");
    }

    
  }
}