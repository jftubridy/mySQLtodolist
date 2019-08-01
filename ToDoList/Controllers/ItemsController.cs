using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")]
        //Route name-- the route is index(), per restful requirements

        //url path -- we specify the path /items in our route decorator

        // http method-- the route decorator denotes that this route   will respond to GET requests by using the httpget method.
       //purpose -- this route is meant to display a list of all items
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string description)
        {
            Item myItem = new Item(description);
            return RedirectToAction("Index");
        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }

        [HttpGet("/items/{id}")]
        public ActionResult Show(int CanBeANyTHINGfORiD)
        {
            Item foundItem = Item.Find(CanBeANyTHINGfORiD);
            return View(foundItem);
        }

    }
}