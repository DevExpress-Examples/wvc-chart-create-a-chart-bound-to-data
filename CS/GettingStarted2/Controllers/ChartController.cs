using GettingStarted2.Models;
using System.Linq;
using System.Web.Mvc;

namespace GettingStarted2.Controllers {
    public class ChartController : Controller {
        public ActionResult Index() {
            using(var context = new NwindDbContext()) {
                Category beveragesCategory = context.Categories
                        .Where(c => c.CategoryName == "Beverages")
                        .Single();
                return View(beveragesCategory.Products.ToList());
            }
        }
    }
}