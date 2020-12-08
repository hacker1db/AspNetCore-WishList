using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Items.ToList();
            return View("Index", model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Create(Models.Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var item = _context.Items.FirstOrDefault(e => e.Id == id);
            _context.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    
    }
}
