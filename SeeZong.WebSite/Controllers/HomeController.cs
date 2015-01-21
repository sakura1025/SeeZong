using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeeZong.WebSite.Models;

namespace SeeZong.WebSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category(int id)
        {
            return View();
        }

        public ActionResult Article(int id)
        {
            //using (SeeZong.WebSite.Models.SeeZongContext db = new Models.SeeZongContext())
            //{
            //    var model = db.Article.Where(m => m.Id == id).FirstOrDefault();
            //    if (null == model)
            //    {
            //        model = new Models.Article();
            //        model.ArticleTags = new List<Models.ArticleTag>();
            //        ArticleTag at = new ArticleTag();
            //        at.Tag = new Tag { TagName = "asdf", Id = 1 };
            //        model.ArticleTags.Add(at);
            //        //return View("NotFound");
            //    }
                return View(new Article());
            //}

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
