using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm=new CategoryManager(); //bldeki sınıfı çağırma
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBL();  //blden oluşan sınıfı çağırmam lazım
            return View(categoryvalues);
        }
    }
}