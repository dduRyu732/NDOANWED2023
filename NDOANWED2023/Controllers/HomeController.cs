using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NDOANWED2023.Models;
using System.IO;


namespace LTW.Controllers
{
    public class HomeController : Controller
    {
        private DBSoTayV3Entities db = new DBSoTayV3Entities();
        public ActionResult Index()
        {
            return View();
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
        public ActionResult TrangChu()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products.ToList());
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Probycate1()
        {
            List<Product> probycate = db.Products.ToList();
            return View(probycate);

        }
        public ActionResult Set()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.ProDetails);

            return View(products.ToList());
        }
        public ActionResult Bia()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.ProDetails);
            return View(products.ToList());
        }
        public ActionResult Ruot()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.ProDetails);
            return View(products.ToList());
        }
        public ActionResult Tap()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.ProDetails);
            return View(products.ToList());
        }
        public ActionResult Phu()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.ProDetails);
            return View(products.ToList());
        }
        public ActionResult ProductDetailView(int? id)
        {

            List<ProDetail> proDetails = db.ProDetails.Include(p => p.Product).Where(p => p.RemainQuantity > 0).ToList();
            return View(proDetails);
        }
    }
}