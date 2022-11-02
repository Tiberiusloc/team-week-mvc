using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using ForageMvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ForageMvc.Controllers
{
  public class ItemsController : Controller
  {
    public IActionResult Index()
    {
      //not sure if we need this?
      var allItems = Item.GetItems();
      return View(allItems);
    }

    public ActionResult Category(string cat)
		{
      var allCatItems = Item.GetCatItems(cat);
			return View(allCatItems);
		}


		public ActionResult Details(int id)
		{
			var thisItem = Item.GetItemDetails(id);
			return View(thisItem);
		}

    [HttpPost]
    public ActionResult Details(Item item)
		{
			Item.PutItem(item);
      return RedirectToAction("Category", new { id = item.ItemId });;
		}
  }
}