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
      List<Vendor> allVendors = Vendor.GetAll();
      return View("Index", allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View("New");
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name)
    {
      Vendor newVendor = new Vendor(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Vendor selectedVendor = Vendor.Find(Id);
      return View("Show", selectedVendor);
    }

    
    
  }
}