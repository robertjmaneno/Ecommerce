using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
           List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        [HttpGet]
        public IActionResult Create() { 
            return View(); }



        [HttpPost]
		public IActionResult Create(Category category)
		{


            if(category.Name==category.DisplayOrder.ToString())
            {

            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();
		}

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Edit(int? id)
        {
            if(id ==null && id==0) { 
                return NotFound();
            }

            Category categoryFromDatabase = _db.Categories.FirstOrDefault(u=>u.CategoryId==id);
            if(categoryFromDatabase == null)
            {
                return NotFound();
            }

            
            return View(categoryFromDatabase);
        }
    }
}
