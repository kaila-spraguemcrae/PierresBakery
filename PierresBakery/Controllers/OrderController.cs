using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      return View(selectedVendor);
    }
  }
} 
