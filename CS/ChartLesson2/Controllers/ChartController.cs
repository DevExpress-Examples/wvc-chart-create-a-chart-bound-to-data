using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace ChartLesson2.Controllers {
    public class ChartController : Controller {
        public ActionResult Index() {
            using (var dbContext = new Models.NwindDbContext()) {
                var category =
                    (from c in dbContext.Categories
                     where c.CategoryName == "Beverages"
                     select c).First();
                var query = 
                    from p in dbContext.Products
                    where p.CategoryID == category.CategoryID
                    select p;
                return View(query.ToList());
            }
        }
    }
}
