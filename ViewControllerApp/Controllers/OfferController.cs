using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewControllerApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViewControllerApp.Controllers
{
    public class OfferController : Controller
    {
        static OfferVm _storage;

        static OfferController()
        {
            _storage = new OfferVm();
            var cats = new[] {
                new Category {Id = CategoryType.First, Text = "Первая"},
                new Category {Id = CategoryType.Second, Text = "2я"},
                new Category {Id = CategoryType.Third, Text = "3я"},
                new Category {Id = CategoryType.Fourth, Text = "4я"},
                new Category {Id = CategoryType.Fifth, Text = "5я"},
                new Category {Id = CategoryType.Sixth, Text = "6я"},
                new Category {Id = CategoryType.Seventh, Text = "7я"}
            };
            _storage.Categories = cats.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Text });
            _storage.SelectedItems = new CategoryType[] { CategoryType.Fifth, CategoryType.Second, CategoryType.First };
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View(_storage);
        }

        [HttpPost]
        public IActionResult Index(OfferVm vm)
        {
            _storage.SelectedItems = vm.SelectedItems.ToArray();
            return View(_storage);
        }
    }
}
