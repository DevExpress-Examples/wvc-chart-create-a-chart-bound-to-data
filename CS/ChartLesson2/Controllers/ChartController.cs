using System.Linq;
using System.Web.Mvc;

namespace ChartLesson2.Controllers {
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            using (var dbContext = new Models.NwindDbContext()) {
                var query = from p in dbContext.Products
                            join c in dbContext.Categories on p.CategoryID equals c.CategoryID
                            where c.CategoryName == "Beverages"
                            select p;
                return View(query.ToArray());
            }
        }
    }
}