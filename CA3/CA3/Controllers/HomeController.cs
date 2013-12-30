using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA3.Models;       // for entity framework
using PagedList;        // for paged list
using PagedList.Mvc;    //

namespace CA3.Controllers
{
    public class HomeController : Controller
    {
        northwndEntities nw = new northwndEntities();
        //
        // GET: /Home/

        public ActionResult Index( int? page)   // ? means nullable, we will use this var as a page count
        {                                         
            var displayAllProducts = from p in nw.Products
                                     select p;
            return View(displayAllProducts.OrderBy(p => p.ProductID).ToPagedList(page ?? 1, 6)); ///  paged list : page ?? 1 means if the page number is null, we set it to 1
                                                                                                ///  ,6 means the page will display 6 entries in one page
                                                                                                ///  PagedList also requires a 
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
